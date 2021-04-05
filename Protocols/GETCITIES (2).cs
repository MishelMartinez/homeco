using InmobiliariasHomeCo.Entities.Pojos.City;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Validations;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETCITIES : JsonSubCommand<CityMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, CityMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            //City1[] cities = InmobiliariasHomeCo.App.DataAccess.DataAccessCity.GetCities();

            //if (cities != null)
            //{
            //    CityMessage[] cityMessage = ConvertCityMessage(cities);

            //    session.Send(String.Format("420 {0}", session.AppServer.JsonSerialize(cityMessage)));
            //}
            //else
            {
                session.Send("{'IdCity':1}");
            }
        }

        private CityMessage[] ConvertCityMessage(City1[] cities)
        {
            CityMessage[] cityMessage = new CityMessage[cities.Length];
            for (int i = 0; i < cities.Length; i++)
            {
                cityMessage[i] = new CityMessage
                {
                    IdCity = cities[i].IdCity.ToString(),
                    Name = cities[i].Name
                };
            }
            return cityMessage;
        }
    }
}
