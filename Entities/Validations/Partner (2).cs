using InmobiliariasHomeCo.Entities.Persons;
using System;

namespace RealEstateHomeCo.Entities.Validations
{
    public class Partner:Person
    {
        public int      IdSalesRep      { get; set; }
        public string   Title           { get; set; }
        public string   Photo           { get; set; }
        public string   TaxRef          { get; set; }
        public short    IdBank          { get; set; }
        public string   BankReference   { get; set; }

    }
}
