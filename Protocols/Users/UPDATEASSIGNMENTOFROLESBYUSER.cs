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
    public class UPDATEASSIGNMENTOFROLESBYUSER : JsonSubCommand<PropertyMessage>

    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado UPDATEASSIGNMENTOFROLESBYUSER");

            DatesSecurity dates = new DatesSecurity()

            {   IdUser  = commandInfo.IdUser,
                Client  = commandInfo.Client,
                Roles   =   commandInfo.Roles

            };

            DatesSecurity securityMessage = new DatesSecurity()
            {
                IdUser = App.DataAccess.DataAccessUsers.UpdateUser(dates),
                StatusAssignmentRoles = App.DataAccess.DataAccessUsers.AssigmentRoles(dates)

            };

            session.Send((session.AppServer.JsonSerialize(securityMessage)));


        }
    }
}
