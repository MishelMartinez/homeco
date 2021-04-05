using System;
using InmobiliariasHomeCo.Entities.Persons;
using InmobiliariasHomeCo.Entities.Persons.SalesReps;

namespace InmobiliariasHomeCo.Entities
{
    public class SalesRep:Person
    {
        public SalesRep         SalesRepParent  { get; set; } 
        public int              Id_SalesRep     { get; set; }
        public  DateTime        InitialDate     { get; set; } 
        public  BankData        BankData        { get; set; }   
        public  EducationLevel  EducationLevel  { get; set; }
        public  string          URLPhoto        { get; set; }
        public  string          TaxRef          { get; set; }
    }
}
