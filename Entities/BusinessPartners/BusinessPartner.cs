using InmobiliariasHomeCo.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.BusinessPartners
{
    public class BusinessPartner :Person
    {
       
        public string   Description { get; set; }

        public Boolean  Status      { get; set; }

    }
}
