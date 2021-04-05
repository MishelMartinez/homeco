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
    public class GETTYPEOFOPERATION : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            TypeOfOperation[] searchs = App.DataAccess.DataAccessTypeOfOperation.GetTypeOfOperation();
            if (searchs != null)
            {
                TypeOfOperationMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}", session.AppServer.JsonSerialize(SearchMessage)));

            }
        }

        private TypeOfOperationMessage[] ConvertToSearchMessage(TypeOfOperation[] searchs)
        {
            TypeOfOperationMessage[] SearchMessage = new TypeOfOperationMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new TypeOfOperationMessage()
                {
                    Id = searchs[i].Id.ToString(),
                    Description = searchs[i].Description
                };
            }

            return SearchMessage;
        }
    }
}
