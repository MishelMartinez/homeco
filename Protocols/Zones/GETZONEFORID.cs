using InmobiliariasHomeCo.Entities.Pojos.Properties;
using InmobiliariasHomeCo.Entities.Pojos.Search;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.Zones
{
    public class GETZONEFORID : JsonSubCommand<StateMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, StateMessage commandInfo)
        {

            StateMessage stateMessage = new StateMessage()
            {
                Id = commandInfo.Id
            };
            Entities.Pojos.Zone.ZoneMessage zoneMessage = new Entities.Pojos.Zone.ZoneMessage()
            {
                Zones = App.DataAccess.DataAccessProperty.GetZone(stateMessage)
            };

            session.Send(App.DataAccess.DataAccessProperty.GetZone(stateMessage));


        }
    }
}
