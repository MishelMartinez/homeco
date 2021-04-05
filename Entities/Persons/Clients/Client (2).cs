using InmobiliariasHomeCo.Entities.BusinessPartners;
using InmobiliariasHomeCo.Entities.Persons;
using System;

namespace InmobiliariasHomeCo.Entities
{
    public class Client:Person
    {
       //public       int             Id              { get; set; }


        public      DateTime        CreateDate      { get; set; }
        public      BusinessPartner BusinessPartner { get; set; }

        public      string          CivilStatus     { get; set; }

        public      int             NumberChildren { get; set; }

        public      Boolean         StatusRegisterClient { get; set; }

    }
}
