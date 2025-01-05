using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankQueueApp
{
    public partial class TellerForm : Form
    {
        private readonly ApiService _apiService;
        private HubConnection _hubConnection;

        public TellerForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void TellerForm_Load(object sender, EventArgs e)
        {
            await InitializeSignalRAsync();
            await LoadQueueDataAsync();
        }

        private async Task InitializeSignalRAsync()
        {
            _hubConnection = new HubConnectionBuilder()
                .WithUrl("https://localhost:7096/queueHub")
                .Build();

            _hubConnection.On("QueueUpdated", async () =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(async () => await LoadQueueDataAsync()));
                }
                else
                {
                    await LoadQueueDataAsync();
                }
            });

            _hubConnection.On<string>("CurrentlyServingUpdated", (currentlyServing) =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() =>
                    {
                        lblCurrentQueue.Text = currentlyServing;
                    }));
                }
                else
                {
                    lblCurrentQueue.Text = currentlyServing;
                }
            });

            await _hubConnection.StartAsync();
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
            string queueNumber = selectedItem.Split('-')[0].Trim().Replace("Queue", "").Trim();

            try
            {
                var data = new { QueueNumber = queueNumber, TellerNumber = (object)null };

                bool success = await _apiService.CallNextAsync(data);
                if (success)
                {
                    await LoadQueueDataAsync();
                    string currentlyServing = $"Currently Serving: {queueNumber}";
                    lblCurrentQueue.Text = currentlyServing;
                    await NotifyCurrentlyServingAsync(currentlyServing);
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
                bool success = await _apiService.MarkAsServedAsync(queueNumber.Trim());
                if (success)
                {
                    await LoadQueueDataAsync();
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
                bool success = await _apiService.SkipCustomerAsync(queueNumber.Trim());
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

        private async Task NotifyCurrentlyServingAsync(string currentlyServing)
        {
            try
            {
                if (_hubConnection != null && _hubConnection.State == HubConnectionState.Connected)
                {
                    await _hubConnection.InvokeAsync("UpdateCurrentlyServing", currentlyServing);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error notifying currently serving update: {ex.Message}");
            }
        }
    }
}