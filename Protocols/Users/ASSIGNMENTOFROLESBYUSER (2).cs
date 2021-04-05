using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.Roles;

namespace InmobiliariasHomeCo.Protocols.Users
{
    public class ASSIGNMENTOFROLESBYUSER : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado ASSIGNMENTOFROLESBYUSER");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            DatesSecurity dates = new DatesSecurity()

            {
                IdUser = commandInfo.IdUser,
                Roles =  commandInfo.Roles
               
            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                StatusAssignmentRoles = App.DataAccess.DataAccessUsers.AssigmentRoles(dates)

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));

        }
    }
}
