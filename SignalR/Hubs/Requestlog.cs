using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalR.Hubs
{
    public class Requestlog: Hub
    {
        public void Send(string name, string message, string connId)
        {
            Clients.Client(connId).appendNewMessage(name, message);
        }
    }

}