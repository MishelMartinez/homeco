﻿using InmobiliariasHomeCo.Entities.Pojos.City;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Validations;
using InmobiliariasHomeCo.Entities.Pojos.Properties;

namespace InmobiliariasHomeCo.Protocols.Advanced_Search
{
    public class GETASADVANCEDSEARCHPROPERTYFORSALE : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.GetAdShAdvancedSearchPropertyForSale(
                int.Parse(commandInfo.CityKey),
                int.Parse(commandInfo.ColonyKey),
                int.Parse(commandInfo.PriceMax),
                int.Parse(commandInfo.PriceMin),
                int.Parse(commandInfo.NumRooms),
                int.Parse(commandInfo.NumBath),
                int.Parse(commandInfo.Id_PropertyType),
                int.Parse(commandInfo.Id_PropertySubType),
                string.Concat(commandInfo.Furnished)
                )));
        }
    }
}