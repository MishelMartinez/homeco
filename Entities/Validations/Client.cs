using InmobiliariasHomeCo.Entities.Persons;
using System;

namespace RealEstateHomeCo.Entities.Validations
{
    public class Client:Person
    {
        public int      IdCustomer { get; set; }
        public int      IdSalesRep { get; set; }
    }
}
