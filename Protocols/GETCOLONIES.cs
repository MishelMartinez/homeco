using InmobiliariasHomeCo.Entities.Pojos.Colony;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using RealEstateHomeCo.Entities.Validations;

namespace InmobiliariasHomeCo.Protocols
{
    class GETCOLONIES : JsonSubCommand<ColonyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, ColonyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Colony[] colonies = InmobiliariasHomeCo.App.DataAccess.DataAccessColony.GetColonies();

            if (colonies != null)
            {
                ColonyMessage[] colonyMessage = ConvertColonyMessage(colonies);

                session.Send(String.Format("420 {0}", session.AppServer.JsonSerialize(colonyMessage)));
            }
            else
            {
                session.Send("421 Error");
            }
        }

        private ColonyMessage[] ConvertColonyMessage(Colony[] colonies)
        {
            ColonyMessage[] colonyMessage = new ColonyMessage[colonies.Length];
            for (int i = 0; i < colonies.Length; i++)
            {
                colonyMessage[i] = new ColonyMessage
                {
                    IdCity = colonies[i].IdCity.ToString(),
                    Name = colonies[i].Name
                };
            }
            return colonyMessage;
        }
    }
}
