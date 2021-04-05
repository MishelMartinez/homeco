using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;

namespace InmobiliariasHomeCo.Protocols.Userss
{
    public class SETUSER : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;



            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.SetUser(
                    string.Concat(commandInfo.NameUser),
                    string.Concat(commandInfo.FullName),	
                    string.Concat(commandInfo.IsEnabled),
                    string.Concat(commandInfo.Email),
                    string.Concat(commandInfo.Passsword)

                )));


        }
    }
}
