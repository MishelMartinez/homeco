using InmobiliariasHomeCo.Entities.Pojos.Gid;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Grid.Consultas;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETGRIDCONSULTAS : JsonSubCommand<GridMessage>

    {
        protected override void ExecuteJsonCommand(WebSocketSession session, GridMessage commandInfo)
        {
            Console.WriteLine("Protocol alcanzado ");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            GridConsultas[] properties = App.DataAccess.DataAccessGrid.GetGridConsultas();

            if (properties != null)
            {
                GridMessage[] propertyMessage = GetGridConsultas(properties);
                session.Send(string.Format("{0}", session.AppServer.JsonSerialize(propertyMessage)));
            }
            else
            {
                Console.WriteLine("210 Error");
            }
        }

        private GridMessage[] GetGridConsultas(GridConsultas[] properties)
        {
            GridMessage[] property = new GridMessage[properties.Length];
            for (int i = 0; i < properties.Length; i++)
            {
                property[i] = new GridMessage()
                {
                   Key = properties[i].Key,
                   Image = properties[i].Image,
                   Property = properties[i].Property,
                   Cost = properties[i].Cost,
                   Operation = properties[i].Operation,
                   State = properties[i].State,
                   Commission = properties[i].Commission,
                   Status = properties[i].Status,

                };
            }
            return property;
        }
    }
}
