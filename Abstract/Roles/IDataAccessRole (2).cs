using InmobiliariasHomeCo.Entities.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InmobiliariasHomeCo.Abstract.Roles
{
    public interface IDataAccessRole
    {

        string                  GetAllRoles();

        int                     RegisterRole(DatesSecurity dates );
        Entities.Roles.Role[]   GetRole(DatesSecurity dates);


        Entities.Roles.Role[]   AllRoles();


        Boolean                 DeleteRoles(DatesSecurity dates);



    }
}
