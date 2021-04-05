using System;
using InmobiliariasHomeCo;
using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Persons;
using InmobiliariasHomeCo.Entities.Pojos.Person;
using InmobiliariasHomeCo.Entities.Validations.MaritalStatus;
using InmobiliariasHomeCo.Protocols;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;


namespace RealEstateHomeCo.Protocols
{
    public class ADDPERSON: JsonSubCommand<PersonMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PersonMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Person person = App.DataAccess.DataAccessPerson.InsertPerson(
                new Client()
                {
                    Name          = commandInfo.Name,
                    PhoneNumber   = commandInfo.PhoneNumber,
                    MobilNumber   = commandInfo.MovilNumber,
                    Email         = commandInfo.Email,
                    RegDate       = DateTime.Parse(commandInfo.RegDate),
                    MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus), commandInfo.MaritalStatus),
                    BirthDate     = DateTime.Parse(commandInfo.BirthDate),
                    Gender        = new Gender() { Description = commandInfo.Gender },
                    ChildrenNUmber   = int.Parse(commandInfo.NumChildren)
                }
           );
        }
    }
}
