using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.Persons.Users;

namespace InmobiliariasHomeCo.Protocols.Polls
{
    public class REGISTERSURVEY : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado REGISTERSURVEY");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            DatesSecurity dates = new DatesSecurity()

            {
                IdUser = commandInfo.IdUser,
                Poll = commandInfo.Poll
                
            };
            /*
            User user = App.DataAccess.DataAccessUsers.GetUser(dates);

            dates = new DatesSecurity()
            {
                Client = user
            };
            */


            session.Send((session.AppServer.JsonSerialize(App.DataAccess.DataAccessPolls.RegisterSurvey(dates))));
        }
    }
}
