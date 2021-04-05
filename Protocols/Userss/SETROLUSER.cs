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
    public class SETROLUSER : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.DeleteRolUser(
                   int.Parse(commandInfo.Id_User)

               )));

            for (int i = 0; i< commandInfo.Id_Role.Length; i++)
            {
                session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.SetRolUser(
                    int.Parse(commandInfo.Id_User),
                    int.Parse(commandInfo.Id_Role[i])

                )));
            }
            


        }
    }
}
