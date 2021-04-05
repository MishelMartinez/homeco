using InmobiliariasHomeCo.Entities.Pojos.Owner;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Persons.Owners;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETOWNERS : JsonSubCommand<OwnerMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, OwnerMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Owner[] owners = InmobiliariasHomeCo.App.DataAccess.DataAccessOwner.GetOwners();

            if (owners != null)
            {
                OwnerMessage[] ownermessage = ConvertOwnerMessage(owners);

                session.Send(String.Format("420 {0}", session.AppServer.JsonSerialize(ownermessage)));
            }
            else
            {
                session.Send("421 Error");
            }
        }

        private OwnerMessage[] ConvertOwnerMessage(Owner[] owners)
        {
            OwnerMessage[] ownerMessage = new OwnerMessage[owners.Length];

            for (int i = 0; i < owners.Length; i++)
            {
                ownerMessage[i].IdOwner = owners[i].IdOwner.ToString();
                ownerMessage[i].Name = owners[i].Name;
            }

            return ownerMessage;
        }
    }
}
