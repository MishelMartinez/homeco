using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.HCProperty
{
    public class HCGETPROPERTY : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.HCGetProperty(
                    int.Parse(commandInfo.PropertyTypeKey  ),
                    int.Parse(commandInfo.TypeOperationKey ),
                    int.Parse(commandInfo.StateKey         ),
                    int.Parse(commandInfo.CityKey          )
                )));
        }
    }
}