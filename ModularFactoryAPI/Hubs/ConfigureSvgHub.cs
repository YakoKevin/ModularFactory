using Microsoft.AspNetCore.SignalR;

namespace ModularFactoryAPI.Hubs
{
    public class ConfigureSvgHub : Hub
    {
        public void BroadcastSvgConfiguration(string id, string svgConfiguration)
        {
            Clients.All.SendAsync("ReceiveSvgConfiguration", id, svgConfiguration);
        }
    }
}
