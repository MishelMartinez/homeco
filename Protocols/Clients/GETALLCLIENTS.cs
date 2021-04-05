using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Clients
{
    public class GETALLCLIENTS : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado GETALLCLIENTS");

            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
           
            DatesSecurity securityMessage = new DatesSecurity()
            {

                AllClients = App.DataAccess.DataAccessClient.GetAllClients()


            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));
            
        }
    }
}
