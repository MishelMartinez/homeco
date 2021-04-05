using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;

namespace InmobiliariasHomeCo.Protocols.Modules
{
    public class ASSIGNMENTOFMODULESBYROLE : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            DatesSecurity dates = new DatesSecurity()

            {
                Modules = commandInfo.Modules,
                //Roles = commandInfo.Roles
                IdRole  = commandInfo.IdRole

            };
            

            DatesSecurity securityMessage = new DatesSecurity()
            {
                StatusAssignmentModule = App.DataAccess.DataAccessModules.AssignmentOfModuleByRole(dates)

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));


        }
    }
}
