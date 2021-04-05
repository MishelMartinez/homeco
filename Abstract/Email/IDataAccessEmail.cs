using InmobiliariasHomeCo.Entities.Pojos.SendEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Email
{
    public interface IDataAccessEmail
    {

        InformationRequestMessage SendInformationSalesBussines(InformationRequestMessage information);
    }
}
