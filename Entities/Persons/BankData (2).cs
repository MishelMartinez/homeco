using System;
using InmobiliariasHomeCo.Entities.Persons.BankData;

namespace InmobiliariasHomeCo.Entities
{
    public class BankData
    {
        public  int         IdBankData      { get; set; }
        public  BankTypes   BankTypes       { get; set; }
        public string       Reference       { get; set; }
    }
}
