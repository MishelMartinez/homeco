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

namespace InmobiliariasHomeCo.Protocols
{
    public class GETPROPERTIESTECHNICALSHEET : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.GetPropertiesTechnicalSheet(
                int.Parse(commandInfo.PropertyKey)
                )));


        }
    }
}
