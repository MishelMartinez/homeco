using InmobiliariasHomeCo.Entities.Persons;
using System;


namespace InmobiliariasHomeCo.Entities
{
    public class Customer:Person
    {
        public int IdCustomer    { get; set; }
        public SalesRep SalesRep { get; set; }
    }
}
