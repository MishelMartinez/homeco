using InmobiliariasHomeCo.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Modules
{
    public interface IDataAccessModules
    {
        Boolean AssignmentOfModuleByRole(DatesSecurity datesSecurity);


        Module[] GetPermissionModule(DatesSecurity datesSecurity);

        string GetAllModules();
            
    }
}
