using InmobiliariasHomeCo.Entities.Pojos.City;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Validations;
using InmobiliariasHomeCo.Entities.Pojos.Properties;

namespace InmobiliariasHomeCo.Protocols.Users
{
    public class SETUSERS : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.SetUsers(
                string.Concat(commandInfo.UserName),int.Parse(commandInfo.Id_Rol), string.Concat(commandInfo.FullName),string.Concat(commandInfo.CreateDate),Boolean.Parse(commandInfo.IsEnabled), Boolean.Parse(commandInfo.IsAdminBms), string.Concat(commandInfo.Email)
                )));

        }
    }
}
