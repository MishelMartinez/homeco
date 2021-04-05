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
    public class DELETEUSER : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado DELETEUSER");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DatesSecurity dates = new DatesSecurity()

            {
                IdUser = commandInfo.IdUser

            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                StatusDeleteUser = App.DataAccess.DataAccessUsers.DeleteUser(dates)

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));




        }
    }
}
