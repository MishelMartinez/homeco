using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Security
{
    public class STATUSSECURITYSTRING : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado STATUSSECURITYSTRING");

            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DatesSecurity dates = new DatesSecurity()
            {
                Base = commandInfo.Base
            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                Status = App.DataAccess.DataAccessSecurity.StatusValidationString(dates)
            };
            session.Send(session.AppServer.JsonSerialize(securityMessage));


        }
    }
}
