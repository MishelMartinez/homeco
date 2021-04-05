using InmobiliariasHomeCo.Entities.Pojos.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Pojos.Owner
{
    public class OwnerMessage : PersonMessage
    {
        public string IdOwner { get; set; }
        public string Id_SalesRep { get; set; }
        public string Id_SalesRep2 { get; set; }
    }
}
