using InmobiliariasHomeCo.Entities.Pojos.Search;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETZONE : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Zone[] searchs = App.DataAccess.DataAccessZone.GetZone();
            if (searchs != null)
            {
                ZoneMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}", session.AppServer.JsonSerialize(SearchMessage)));

            }
        }

        private ZoneMessage[] ConvertToSearchMessage(Zone[] searchs)
        {
            ZoneMessage[] SearchMessage = new ZoneMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new ZoneMessage()
                {
                    Id = searchs[i].Id.ToString(),
                    Areas = searchs[i].Areas
                };
            }

            return SearchMessage;
        }
    }
}
