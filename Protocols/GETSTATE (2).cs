using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;
using InmobiliariasHomeCo.Entities.Pojos.Search;
using OKYSoft.Net.WebSocket.SubProtocol;
using OKYSoft.Net.WebSocket;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETSTATE : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            States[] searchs = App.DataAccess.DataAccessState.GetState();
            if (searchs != null)
            {
                StateMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}", session.AppServer.JsonSerialize(SearchMessage)));

            }
        }

        private StateMessage[] ConvertToSearchMessage(States[] searchs)
        {
            StateMessage[] SearchMessage = new StateMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new StateMessage()
                {
                    Id = searchs[i].Id.ToString(),
                    State = searchs[i].State
                };
            }

            return SearchMessage;
        }
    }
}
