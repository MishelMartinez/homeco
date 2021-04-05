using InmobiliariasHomeCo.Entities.Pojos.Search;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Protocols.Protocols_GetDataSheet
{
    public class GETPROPERTYTYPE : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            PropertyType[] searchs = App.DataAccess.DataAccessPropertyType.GetPropertyType();
            if (searchs != null)
            {
                PropertyTypeMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}",session.AppServer.JsonSerialize(SearchMessage)));

            }
            
        }
        private PropertyTypeMessage[] ConvertToSearchMessage(PropertyType[] searchs)
        {
            PropertyTypeMessage[] SearchMessage = new PropertyTypeMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new PropertyTypeMessage()
                {
                    Id           =   searchs[i].Id.ToString(),
                    Description  =   searchs[i].Description
                };
            }

            return SearchMessage;
        }
    }
}
