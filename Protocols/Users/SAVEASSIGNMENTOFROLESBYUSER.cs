using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Users
{
    public class SAVEASSIGNMENTOFROLESBYUSER : JsonSubCommand<PropertyMessage>

    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            DatesSecurity dates = new DatesSecurity()

            {
                Client  = commandInfo.Client,
                Roles   =   commandInfo.Roles

            };




        }
    }
}
