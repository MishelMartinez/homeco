using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Pojos.SendEmail
{
    public class InformationRequestMessage
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }

        public string PropertyCode { get; set; }
        public int IdProperty { get; set; }
        public int IdBusinessPartner { get; set; }
        public string NameBussinesPartner { get; set; }

        public string EmailBussinesPartner { get; set; }

    
       

    }
}
