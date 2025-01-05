using Newtonsoft.Json;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankQueueApp
{
    public partial class TellerForm : Form
    {
        private readonly ApiService _apiService;

        public TellerForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void TellerForm_Load(object sender, EventArgs e)
        {
            await LoadQueueDataAsync();
        }

        private async Task LoadQueueDataAsync()
        {
            try
            {
                var queueData = await _apiService.GetQueueForTellerAsync();

                listBoxWaitingQueue.Items.Clear();
                foreach (var queueItem in queueData)
                {
                    listBoxWaitingQueue.Items.Add($"Queue {queueItem.QueueNumber} - {queueItem.ServiceType} ({queueItem.Status})");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading queue data: {ex.Message}");
            }
        }

        private async void btnCallNext_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingQueue.SelectedItem == null)
            {
                MessageBox.Show("Please select a queue to call next.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedItem = listBoxWaitingQueue.SelectedItem.ToString();
            string queueNumber = selectedItem.Split('-')[0].Trim().Replace("Queue", "");

            queueNumber = queueNumber.Trim();

            try
            {
                var data = new
                {
                    QueueNumber = queueNumber,
                    TellerNumber = (object)null
                };

                Console.WriteLine($"Sending Data: {JsonConvert.SerializeObject(data)}");

                bool success = await _apiService.CallNextAsync(data);
                if (success)
                {
                    await LoadQueueDataAsync();
                    await UpdateCurrentQueueLabelAsync();
                }
                else
                {
                    MessageBox.Show("Error calling next customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calling next customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UpdateCurrentQueueLabelAsync()
        {
            try
            {
                var queueData = await _apiService.GetQueueForTellerAsync();

                var currentQueue = queueData.FirstOrDefault(q => q.Status == "In Service");

                if (currentQueue != null)
                {
                    lblCurrentQueue.Text = $"Currently Serving: {currentQueue.QueueNumber} - {currentQueue.ServiceType}";
                }
                else
                {
                    lblCurrentQueue.Text = "No customer is currently being served.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating current queue label: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnMarkAsServed_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingQueue.SelectedItem == null)
            {
                MessageBox.Show("Please select a queue to mark as served.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedItem = listBoxWaitingQueue.SelectedItem.ToString();
            string queueNumber = selectedItem.Split('-')[0].Trim().Replace("Queue", "");

            queueNumber = queueNumber.Trim();

            try
            {
                bool success = await _apiService.MarkAsServedAsync(queueNumber);
                if (success)
                {
                    await LoadQueueDataAsync();
                    await UpdateCurrentQueueLabelAsync();
                }
                else
                {
                    MessageBox.Show("Error marking as served.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error marking as served: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSkip_Click(object sender, EventArgs e)
        {
            if (listBoxWaitingQueue.SelectedItem == null)
            {
                MessageBox.Show("Please select a queue to skip.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedItem = listBoxWaitingQueue.SelectedItem.ToString();
            string queueNumber = selectedItem.Split('-')[0].Trim().Replace("Queue", "");

            queueNumber = queueNumber.Trim();

            try
            {
                bool success = await _apiService.SkipCustomerAsync(queueNumber);
                if (success)
                {
                    await LoadQueueDataAsync();
                }
                else
                {
                    MessageBox.Show("Error skipping customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error skipping customer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}