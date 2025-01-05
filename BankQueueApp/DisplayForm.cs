using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankQueueApp
{
    public partial class DisplayForm : Form
    {
        private readonly ApiService _apiService;
        private HubConnection _hubConnection;

        public DisplayForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void DisplayForm_Load(object sender, EventArgs e)
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
                var queueData = await _apiService.GetQueueDataAsync();

                lblCustomersInQueue.Text = $"Waiting: {queueData.QueueCount}";

                listBoxQueue.Items.Clear();
                foreach (var waitingQueue in queueData.WaitingQueue)
                {
                    listBoxQueue.Items.Add($"{waitingQueue.QueueNumber} - {waitingQueue.ServiceType}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading queue data: {ex.Message}");
            }
        }
    }

    public class QueueData
    {
        public QueueItem CurrentQueue { get; set; }
        public int QueueCount { get; set; }
        public List<QueueItem> WaitingQueue { get; set; }
    }

    public class QueueItem
    {
        public int Id { get; set; }
        public string QueueNumber { get; set; }
        public string ServiceType { get; set; }
        public int? TellerNumber { get; set; }
        public string Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}