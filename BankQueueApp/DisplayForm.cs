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

        public DisplayForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void DisplayForm_Load(object sender, EventArgs e)
        {
            await LoadQueueDataAsync();
        }

        private async Task LoadQueueDataAsync()
        {
            try
            {
                var queueData = await _apiService.GetQueueDataAsync();

                if (queueData.CurrentQueue != null)
                {
                    lblCurrentQueue.Text = $"Currently Serving: {queueData.CurrentQueue.QueueNumber}";
                    //lblAssignedTeller.Text = $"Assigned Teller: {queueData.CurrentQueue.TellerNumber}";
                }
                else
                {
                    lblCurrentQueue.Text = "Currently Serving: None";
                    //lblAssignedTeller.Text = "Assigned Teller: None";
                }

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