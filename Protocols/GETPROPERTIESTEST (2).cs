using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Pojos;
using InmobiliariasHomeCo.Entities.Pojos.Properties;
using InmobiliariasHomeCo.Entities.Properties;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETPROPERTIESTEST : JsonSubCommand<PropertyTestMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTestMessage commandInfo)
        {
            Console.WriteLine("Protocol alcanzado ");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            PropertyTest[] properties = App.DataAccess.DataAccessProperty.GetPropertiesTest();

            if (properties != null)
            {
                PropertyTestMessage[] propertyMessage = GetProperties(properties);
                session.Send(string.Format("{0}", session.AppServer.JsonSerialize(propertyMessage)));
            }
            else
            {
                Console.WriteLine("210 Error");
            }
        }

        private PropertyTestMessage[] GetProperties(PropertyTest[] properties)
        {
            PropertyTestMessage[] property = new PropertyTestMessage[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                property[i] = new PropertyTestMessage()
                {
                    state = properties[i].state,
                    price = properties[i].price.ToString(),
                    partnernumber = properties[i].partnernumber.ToString(),
                    img = properties[i].img,
                    size = properties[i].size.ToString(),
                    numberbathrooms = properties[i].numberbathrooms.ToString(),
                    numberrooms = properties[i].numberrooms.ToString(),
                    firstname = properties[i].firstname,

                    zona = properties[i].zona,
                    Location = properties[i].Location,
                    estado = properties[i].estado,
                    rentaventa = properties[i].rentaventa
                };
            }
            return property;
        }
    }
}
