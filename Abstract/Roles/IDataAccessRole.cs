using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InmobiliariasHomeCo.Abstract.Roles
{
    public interface IDataAccessRole
    {

        string GetAllRoles();

        Entities.Roles.Role[] AllRoles();


    }
}
