using InmobiliariasHomeCo.Entities.Persons;
using System;

namespace RealEstateHomeCo.Entities.Validations
{
    public class Owner:Person
    {
        public int      IdOwner             { get; set; }
        public int      Id_SalesRep         { get; set; }
        public int      Id_SalesRep2        { get; set; }

    }
}
