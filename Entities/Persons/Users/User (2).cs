using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Persons.Users
{
    public class User
    {
        public int          Id              { get; set; }
        public string       NameUser        { get; set; }
        public string       FullName        { get; set; }
        public string       Email           { get; set; }
        public string       Password       { get; set; }
   
        public DateTime     CreateDate      { get; set; }
        public string       Phone           { get; set; }

        public Boolean      IsEnabled       { get; set; }






    }
}
