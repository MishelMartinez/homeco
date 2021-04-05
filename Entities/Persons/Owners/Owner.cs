using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Persons.Owners
{
    public class Owner:Person
    {
        public int IdOwner        { get; set; }
        public SalesRep SalesRep  { get; set; }
        public SalesRep SalesRep2 { get; set; }
    }
}
