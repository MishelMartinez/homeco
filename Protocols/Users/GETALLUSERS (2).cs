using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Users
{
    public class GETALLUSERS : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo GETALLUSERS");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

          
            
            DatesSecurity securityMessage = new DatesSecurity()
            {
                AllUsers = App.DataAccess.DataAccessUsers.GetAllUsers()
               
            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));
        }
    }
}
