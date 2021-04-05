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
    public class GETMUNICIPALITY : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Municipalities[] searchs = App.DataAccess.DataAccessMunicipality.GetMunicipalities();
            if (searchs != null)
            {
                MunicipalityMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}", session.AppServer.JsonSerialize(SearchMessage)));

            }
        }

        private MunicipalityMessage[] ConvertToSearchMessage(Municipalities[] searchs)
        {
            MunicipalityMessage[] SearchMessage = new MunicipalityMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new MunicipalityMessage()
                {
                    Id = searchs[i].Id.ToString(),
                    Municipalitys = searchs[i].Municipalitys
                };
            }

            return SearchMessage;
        }
    }
}
