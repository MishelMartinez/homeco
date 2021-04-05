using InmobiliariasHomeCo.Entities.Pojos.Search;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.DataSheets;
using InmobiliariasHomeCo.Entities.Pojos.DataSheet;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETDATASHEET : JsonSubCommand<PropertyTypeMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyTypeMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DataSheet[] searchs = App.DataAccess.DataAccesDataSheet.GetDataSheet();
            if (searchs != null)
            {
                DataSheetMessage[] SearchMessage = ConvertToSearchMessage(searchs);

                session.Send(String.Format("{0}", session.AppServer.JsonSerialize(SearchMessage)));

            }
        }

        private DataSheetMessage[] ConvertToSearchMessage(DataSheet[] searchs)
        {
            DataSheetMessage[] SearchMessage = new DataSheetMessage[searchs.Length];

            for (int i = 0; i < searchs.Length; i++)
            {
                SearchMessage[i] = new DataSheetMessage()
                {
                   

                     idinmueble = searchs[i].idinmueble.ToString(),
                     describeimg1 = searchs[i].describeimg1,
                     describeimg2 = searchs[i].describeimg2,
                     describeimg3 = searchs[i].describeimg3,
                     describeimg4 = searchs[i].describeimg4,
                     img1 = searchs[i].img1,
                     img2 = searchs[i].img2,
                     img3 = searchs[i].img3,
                     img4 = searchs[i].img4,
                     tipodeinmueble = searchs[i].tipodeinmueble,
                     colonia = searchs[i].colonia,
                     cp = searchs[i].cp,
                     noexterior = searchs[i].noexterior,
                     state = searchs[i].state,
                     subtipodeinmueble = searchs[i].subtipodeinmueble,
                     zona = searchs[i].zona,
                     calle = searchs[i].calle,
                     nointerior = searchs[i].nointerior,
                     price = searchs[i].price,
                     describe = searchs[i].describe,
                     tamaniodeterreno = searchs[i].tamaniodeterreno,
                     niveles = searchs[i].niveles,
                     habitaciones = searchs[i].habitaciones,
                     cocinaintegrada = searchs[i].cocinaintegrada,
                     construido = searchs[i].construido,
                     mediobanio = searchs[i].mediobanio,
                     banioscompletos = searchs[i].banioscompletos,
                     estacionamiento = searchs[i].estacionamiento,
                     describeareas = searchs[i].describeareas


                };
            }

            return SearchMessage;
        }
    }
}
