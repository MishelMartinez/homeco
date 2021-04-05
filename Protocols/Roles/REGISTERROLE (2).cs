using InmobiliariasHomeCo.Entities.Pojos.Properties;
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
    public class REGISTERROLE : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado REGISTERROLE");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            DatesSecurity dates = new DatesSecurity()

            {

                Roles = commandInfo.Roles

            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                IdRole = App.DataAccess.DataAccessRole.RegisterRole(dates)
               

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));


        }
    }
}
