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
    public class UPDATEASSIGNMENTOFMODULESBYROLE : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado UPDATEASSIGNMENTOFMODULESBYROLE");

            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            DatesSecurity dates = new DatesSecurity()

            {
                IdRole  =   commandInfo.IdRole,
                Roles   =   commandInfo.Roles,
                Modules =   commandInfo.Modules

            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                IdRole = App.DataAccess.DataAccessModules.UpdateAssignmentOfModuleByRole(dates),
                StatusAssignmentModule = App.DataAccess.DataAccessModules.AssignmentOfModuleByRole(dates)

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));



        }
    }
}
