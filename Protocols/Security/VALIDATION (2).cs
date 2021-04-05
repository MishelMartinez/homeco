using InmobiliariasHomeCo.Entities.Pojos.Properties;
using InmobiliariasHomeCo.Entities.Security;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.Val
{
    public class VALIDATION : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado GetValidation");

            WebSocketServerTest server  = session.AppServer as WebSocketServerTest;
            DatesSecurity dates         = new DatesSecurity()

            {
                User            = commandInfo.User,
                Password        = commandInfo.Password
            };
            DatesSecurity datesSecurity = App.DataAccess.DataAccessSecurity.GetStatusUser(dates);
            DatesSecurity securityMessage = new DatesSecurity();


            if (datesSecurity.Status != false)
            {
                 securityMessage = new DatesSecurity
                {
                    Status          = datesSecurity.Status,
                    Base            = GenerateSecurityString(dates),
                    ModulesNavbar   = App.DataAccess.DataAccessSecurity.GetModulesNavbarJson(dates),
                    IdUser          = datesSecurity.IdUser
                    // Modules = App.DataAccess.DataAccessSecurity.GetModulesSecurity(dates)

                };

                session.Send(session.AppServer.JsonSerialize(securityMessage));

            }
            else
            {
                securityMessage.Status = false;


                session.Send(session.AppServer.JsonSerialize(securityMessage));
            }



        }

        private string GenerateSecurityString(DatesSecurity dates)

        {
            double minutes = double.Parse(System.Configuration.ConfigurationManager.AppSettings["Timer"]);

            

            DateTime hourAfter = DateTime.Now.AddMinutes(minutes);

            string securityString = string.Format("{0}&{1}&{2}", dates.User, dates.Password, hourAfter);
            byte[] textAsBytes = Encoding.UTF8.GetBytes(securityString);

            securityString = Convert.ToBase64String(textAsBytes);


            return securityString;

        }
    }
}