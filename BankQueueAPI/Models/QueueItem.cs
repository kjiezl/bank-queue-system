namespace BankQueueAPI
{
    public class QueueItem
    {
        public int Id { get; set; }
        public string? QueueNumber { get; set; }
        public string? ServiceType { get; set; }
        public string? TellerNumber { get; set; }
        public string? Status { get; set; }
        public DateTime Timestamp { get; set; }
    }
}