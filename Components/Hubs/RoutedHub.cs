using Microsoft.AspNetCore.SignalR;
using octisv2.Components.Data;

namespace octisv2.Components.Hubs
{
    
    public class RoutedHub : Hub
    {
        public async Task RefreshRoutes(List<Routed> Routed)
        {
            await Clients.All.SendAsync("RefreshRoutes", Routed);
        }
    }
    
}
