using InmobiliariasHomeCo.Entities.Clients.ParametersOfInterest;
using InmobiliariasHomeCo.Entities.Persons.Users;
using InmobiliariasHomeCo.Entities.Polls;
using InmobiliariasHomeCo.Entities.Roles;
using InmobiliariasHomeCo.Entities.SendEmail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Security
{
    public class DatesSecurity
    {
        public string   User                { get; set; }
        public string   Password            { get; set; }
        

        public Boolean  Status              { get; set; }

        public string   Base                { get; set; }

        public string   ModulesNavbar       { get; set; }

        public string   AllUsers { get; set; }

        public string   AllRoles  { get; set; }

        public string   AllModules { get; set; }

        public string AllClients { get; set; }
        public string   IdUser { get; set; }

        public int      IdRole { get; set; }

        public Role[]   Roles { get; set; }
        public Role      Role { get; set; }
        public Module[] Modules { get; set; }


        public Boolean StatusAssignmentRoles { get; set; }

        public Boolean StatusAssignmentModule { get; set; }


        public Boolean StatusDeleteUser     { get; set; }

        public Boolean StatusDeleteRole         { get; set; }





        public User Client { get; set; } 


        public Poll Poll { get; set; }

        public Boolean StatusRegisterPoll { get; set; }


        // public Permits[] permits { get; set; }


        // CLIENTS

        public Client               client                  { get; set; }
        public ParametersInterest   ParametersInterest      { get; set; }

        public Boolean              StatusRegisterkeyInterest { get; set; }


        //SEND EMAIL

        public InformationRequest   informationRequest      { get; set; }




    }
}
