using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.SalesRep
{
    public class SETSALESREP : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.SetSalesRep(
                string.Concat(commandInfo.RegDate),
                string.Concat(commandInfo.Name),
                string.Concat(commandInfo.PhoneNumber),
                string.Concat(commandInfo.MobilNumber),
                string.Concat(commandInfo.Email),
                string.Concat(commandInfo.BirthDate),
                string.Concat(commandInfo.MaritalStatus),
                    int.Parse(commandInfo.Id_Gender),
                    int.Parse(commandInfo.ChildrenNUmber),
                string.Concat(commandInfo.InitialDate),
                string.Concat(commandInfo.Title),
                string.Concat(commandInfo.URLPhoto),
                string.Concat(commandInfo.TaxRef),
                    int.Parse(commandInfo.Id_Bank),
                string.Concat(commandInfo.BankReference)
                    
                )));
        }
    }
}