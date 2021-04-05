using System;
using InmobiliariasHomeCo.Entities.Pojos.Properties;
using InmobiliariasHomeCo.Entities.Properties;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETPROPERTIES : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocol alcanzado ");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Property[] properties = App.DataAccess.DataAccessProperty.GetProperties();

            if (properties != null)
            {
                PropertyMessage[] propertyMessage = GetProperties(properties);
                session.Send(string.Format("221 {0}", session.AppServer.JsonSerialize(propertyMessage)));
            }
            else
            {
                Console.WriteLine("210 Error");
            }
        }

        private PropertyMessage[] GetProperties(Property[] properties)
        {
            PropertyMessage[] property = new PropertyMessage[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                property[i] = new PropertyMessage()
                {
                    IdProperty = properties[i].IdProperty,
                    PropertyKey = properties[i].PropertyKey
                };
            }
            return property;
        }
    }
}
