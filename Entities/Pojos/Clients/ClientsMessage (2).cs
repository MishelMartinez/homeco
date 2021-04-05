using InmobiliariasHomeCo.Entities.BusinessPartners;
using InmobiliariasHomeCo.Entities.Clients.ParametersOfInterest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Pojos.Clients
{
    public class ClientsMessage
    {

        public Boolean RegisterkeyInterest { get; set; }
        public int    IdUser { get; set; }

        public string Name { get; set; }
        public int Gender { get; set; }
        
        public string PhoneNumber { get; set; }
        public string MobilNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime BirthDate { get; set; }

        public DateTime CreateDate { get; set; }
        public string  IdBusinessPartner { get; set; }

        public string CivilStatus { get; set; }

        public int NumberChildren { get; set; }
        public double MaximumBudget { get; set; }


        public int Coin { get; set; }

        public int TypeProperty { get; set; }

        public int Sector { get; set; }

        public int Zone { get; set; }

        public int Levels { get; set; }

        public int Bedrooms { get; set; }

        public int IdOrigin { get; set; }
        public KeyInterest[] keyInterest { get; set; }

        public KeyShopping[] keyShopping { get; set; }


        // 

        public Boolean StatuskeyInterest { get; set; }
        public Boolean StatuskeyShopping { get; set; }




    }
}
