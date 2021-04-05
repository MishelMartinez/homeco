using InmobiliariasHomeCo.Entities.BusinessPartners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.SendEmail
{
    public class InformationRequest
    {
        public  string          PropertyCode    { get; set; }

        public  int             IdProperty      { get; set; }

        public  Applicant       applicant       { get; set; }

        public  BusinessPartner businessPartner { get; set; }

        public  string          ReceiverEmail   { get; set; }


    }
}
