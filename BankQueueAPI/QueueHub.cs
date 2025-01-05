using Microsoft.AspNetCore.SignalR;

public class QueueHub : Hub
{
    public async Task NotifyQueueUpdated()
    {
        await Clients.All.SendAsync("QueueUpdated");
    }

    public async Task UpdateCurrentlyServing(string currentlyServing)
    {
        await Clients.All.SendAsync("CurrentlyServingUpdated", currentlyServing);
    }
}