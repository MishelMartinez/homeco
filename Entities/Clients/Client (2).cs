using InmobiliariasHomeCo.Entities.Clients.ParametersOfInterest;
using InmobiliariasHomeCo.Entities.Persons;
using InmobiliariasHomeCo.Entities.Persons.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Clients
{
    public class Client:Person
    {

        public int                  IdBusinessPartner { get; set; }

        public ParametersInterest   parametersInterest { get; set; }

    }
}
