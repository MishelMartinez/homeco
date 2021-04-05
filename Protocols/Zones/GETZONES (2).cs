using InmobiliariasHomeCo.Entities.Pojos.Properties;
using InmobiliariasHomeCo.Entities.Pojos.Zone;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.Zones
{
    public class GETZONES : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            ZoneMessage zoneMessage = new ZoneMessage()
            {
                Zones = App.DataAccess.DataAccessProperty.GetZones()
            };

            session.Send(session.AppServer.JsonSerialize(zoneMessage));
        }
    }
}
