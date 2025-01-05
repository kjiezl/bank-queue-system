using System;
using System.Windows.Forms;

namespace BankQueueApp
{
    public partial class KioskForm : Form
    {
        private readonly ApiService _apiService;

        public KioskForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private void KioskForm_Load(object sender, EventArgs e)
        {
            comboBoxServiceType.Items.Add("Deposit");
            comboBoxServiceType.Items.Add("Withdrawal");
            comboBoxServiceType.Items.Add("Account Inquiry");
            comboBoxServiceType.Items.Add("Loan Application");
            comboBoxServiceType.Items.Add("New Account Opening");
            comboBoxServiceType.SelectedIndex = 0;
        }

        private string GenerateQueueNumber()
        {
            Random random = new Random();
            char randomLetter = (char)('A' + random.Next(0, 26)); // Random letter from A to Z
            return randomLetter + (DateTime.Now.Ticks % 1000).ToString();
        }

        private async void btnGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxServiceType.SelectedItem == null)
            {
                MessageBox.Show("Please select a service type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string serviceType = comboBoxServiceType.SelectedItem.ToString();

            string queueNumber = GenerateQueueNumber();

            try
            {
                bool success = await _apiService.AddQueueAsync(queueNumber, serviceType);
                if (success)
                {
                    lblQueueNumber.Text = $"Your Number: {queueNumber}";
                }
                else
                {
                    MessageBox.Show("Error adding queue. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating queue number: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            comboBoxServiceType.SelectedIndex = 0;
        }
    }
}