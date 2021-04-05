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
    public class GETCOLONIES1 : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Colonies[] searchs = App.DataAccess.DataAccesColonies.GetColonies();
            if (searchs != null)
            {
                ColoniesMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}", session.AppServer.JsonSerialize(SearchMessage)));

            }
        }

        private ColoniesMessage[] ConvertToSearchMessage(Colonies[] searchs)
        {
            ColoniesMessage[] SearchMessage = new ColoniesMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new ColoniesMessage()
                {
                    Id = searchs[i].Id.ToString(),
                    Colony = searchs[i].Colony
                };
            }

            return SearchMessage;
        }
    }
}
