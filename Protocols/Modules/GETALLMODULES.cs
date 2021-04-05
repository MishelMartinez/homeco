﻿using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Modules
{
    public class GETALLMODULES : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado GETALLMODULES");

            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DatesSecurity securityMessage = new DatesSecurity()
            {
    
                AllModules = App.DataAccess.DataAccessModules.GetAllModules()

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));
        }
    }
}
