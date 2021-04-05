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
    public class GETALLROLES : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado GETALLROLES");

            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DatesSecurity securityMessage = new DatesSecurity()
            {
                
                AllRoles = App.DataAccess.DataAccessRole.GetAllRoles()
               

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));
        }
    }
}
