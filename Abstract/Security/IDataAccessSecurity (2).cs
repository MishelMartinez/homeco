using InmobiliariasHomeCo.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Security
{
    public interface IDataAccessSecurity
    {

        DatesSecurity GetStatusUser(DatesSecurity datesSecurity );

        Boolean     StatusValidationString(DatesSecurity datesSecurity);


        Module[]    GetModulesSecurity(DatesSecurity datesSecurity);

        string      GetModulesNavbarJson(DatesSecurity datesSecurity);

        int         GetPermits(DatesSecurity datesSecurity);

    }
}
