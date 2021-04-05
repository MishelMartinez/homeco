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
    public class REGISTERUSER : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado REGISTERUSER");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            DatesSecurity dates = new DatesSecurity()

            {
               Client = commandInfo.Client

            };


            session.Send((session.AppServer.JsonSerialize(App.DataAccess.DataAccessUsers.RegisterUser(dates))));
            //IdUser return DatesSecurity
        }
    }
}
