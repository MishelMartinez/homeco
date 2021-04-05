using InmobiliariasHomeCo.Entities.Persons.Owners;
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
    public class ADDPROPERTY : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocol alcanzado ");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Property property = App.DataAccess.DataAccessProperty.InsertProperty(
                new Property()
                {
                    Owner = new Owner()
                    {
                        //IdOwner = commandInfo.
                    }
                }
            );
        }
    }
}
