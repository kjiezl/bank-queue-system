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
            return "A" + DateTime.Now.Ticks % 1000;
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
                    lblQueueNumber.Text = $"Your Queue Number: {queueNumber}";
                    lblTellerAssigned.Text = $"Assigned Teller: TBD (Will be updated at the teller)";
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