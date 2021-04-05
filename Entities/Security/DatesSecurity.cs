using InmobiliariasHomeCo.Entities.Persons.Users;
using InmobiliariasHomeCo.Entities.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Security
{
    public class DatesSecurity
    {
        public string   User { get; set; }
        public string   Password { get; set; }
        

        public Boolean  Status { get; set; }

        public string   Base { get; set; }

        public string   ModulesNavbar { get; set; }

        public string   AllUsers { get; set; }

        public string AllRoles  { get; set; }

        public string AllModules { get; set; }

        public string IdUser { get; set; }

        public int IdRole { get; set; }

        public Role[] Roles { get; set; }
        public Module[] Modules { get; set; }


        public Boolean StatusAssignmentRoles { get; set; }

        public Boolean StatusAssignmentModule { get; set; }

        public User Client { get; set; } 



        // public Permits[] permits { get; set; }



    }
}
