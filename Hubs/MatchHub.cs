using Microsoft.AspNetCore.SignalR;

namespace Cricbuzz.Hubs
{
    public sealed class MatchHub : Hub
    {
        public async Task SendLiveData(int liveData)
        {
            await Clients.All.SendAsync("ReceiveLiveData", liveData);
        }
    }
}