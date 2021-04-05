using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Roles;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.Persons.Users;

namespace InmobiliariasHomeCo.Abstract.Users
{
    public interface IDataAccessUsers
    {

        DatesSecurity RegisterUser(DatesSecurity dates);
        string GetAllUsers();

        Boolean AssigmentRoles              (DatesSecurity dates);


        Role[] EditAssigmentRoles           (DatesSecurity dates);


        User    GetUser                     (DatesSecurity dates);
         
        Boolean UpdateAssigmentRoles        (DatesSecurity dates);

    }
}
