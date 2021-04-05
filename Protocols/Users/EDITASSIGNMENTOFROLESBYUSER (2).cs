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
    public class EDITASSIGNMENTOFROLESBYUSER : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado EDITASSIGNMENTOFROLESBYUSER");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            DatesSecurity dates = new DatesSecurity()

            {
                IdUser = commandInfo.IdUser

            };

            Entities.Roles.Role[] rolesUser = App.DataAccess.DataAccessUsers.EditAssigmentRoles(dates);

         //   Entities.Roles.Role[] allRoles = App.DataAccess.DataAccessRole.AllRoles();

          //  Entities.Roles.Role[] rolesTotal = new Entities.Roles.Role[allRoles.Length];
            /*
            for(int x = 0; x < allRoles.Length; x++)
            {
                for (int y = 0; y < rolesUser.Length; y++)
                {
                    if (allRoles[x].IdRole == rolesUser[x].IdRole)
                    {
                        rolesTotal[x].IdRole = allRoles[x].IdRole;
                        rolesTotal[x].Name = allRoles[x].Name;
                        rolesTotal[x].Status = true;

                    }
                    else
                    {
                        rolesTotal[x].IdRole = allRoles[x].IdRole;
                        rolesTotal[x].Status = false;
                        rolesTotal[x].Name = allRoles[x].Name;
                    }
                }
            }
            */

            for(int x = 0;x < rolesUser.Length; x++)
            {
                rolesUser[x].Status = true;
            }

            DatesSecurity securityMessage = new DatesSecurity()
            {
                Client = App.DataAccess.DataAccessUsers.GetUser(dates),
                Roles   = rolesUser,
                IdUser  = commandInfo.IdUser

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));


        }
    }
}
