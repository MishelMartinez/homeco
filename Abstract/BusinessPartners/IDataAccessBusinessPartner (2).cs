using InmobiliariasHomeCo.Entities.BusinessPartners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.BusinessPartners
{
    public interface IDataAccessBusinessPartner
    {

        BusinessPartner GetBusinessPartner(BusinessPartner businessPartner);

    }
}
