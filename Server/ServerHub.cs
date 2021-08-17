using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerHub : Hub
    {

        public async Task SendSome(List<string> items)
        {
            await Clients.All.SendAsync("ReceiveSome", items);
        }

    }
}
