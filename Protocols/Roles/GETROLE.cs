﻿using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Roles
{
    public class GETROLE : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado GETROLE");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DatesSecurity dates = new DatesSecurity()

            {
                IdRole = commandInfo.IdRole

            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                Roles = App.DataAccess.DataAccessRole.GetRole(dates)

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));
        }
            

    }
}
