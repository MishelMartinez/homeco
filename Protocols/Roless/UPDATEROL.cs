using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;

namespace InmobiliariasHomeCo.Protocols.Roless
{
    public class UPDATEROL : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;



            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.UpdateRol(
                        int.Parse(commandInfo.Id_Rol),
                    string.Concat(commandInfo.Name),
                    string.Concat(commandInfo.Description)
                )));


        }
    }
}
