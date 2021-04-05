using System;
using InmobiliariasHomeCo.Entities.Persons;
using InmobiliariasHomeCo.Entities.Pojos.Person;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;

namespace InmobiliariasHomeCo.Protocols
{
    public class GETPERSONS : JsonSubCommand<PersonMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PersonMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            Person[] persons = InmobiliariasHomeCo.App.DataAccess.DataAccessPerson.GetPersons();

            if (persons != null)
            {
                PersonMessage[] personmessage = ConvertPersonMessage(persons);
               
                session.Send(String.Format("420 {0}", session.AppServer.JsonSerialize(personmessage)));
            }
            else
            {
                session.Send("421 Error");
            }
        }
        private PersonMessage[] ConvertPersonMessage(Person[] persons)
        {
            PersonMessage[] personmessage = new PersonMessage[persons.Length];
            for (int i = 0; i < persons.Length; i++)
            {
                personmessage[i] = new PersonMessage
                {
                    Name          = persons[i].Name,
                    PhoneNumber   = persons[i].PhoneNumber,
                    MovilNumber   = persons[i].MobilNumber,
                    Email         = persons[i].Email,
                    RegDate       = persons[i].RegDate.ToString("MM'/'dd'/'yyyy HH':'mm':'ss.fff"),
                    MaritalStatus = persons[i].MaritalStatus.ToString(),
                    BirthDate     = persons[i].BirthDate.ToString("MM'/'dd'/'yyyy HH':'mm':'ss.fff"),
                    Gender        = persons[i].Gender.Description,
                    NumChildren   = persons[i].ChildrenNUmber.ToString()
                };
            }
            return personmessage;
        }
    }
}
