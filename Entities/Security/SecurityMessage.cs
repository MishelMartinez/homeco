using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Security
{
    public class SecurityMessage
    {
        public Boolean Status { get; set; }

        public string Base   { get; set; }

        public Module[] Modules { get; set; }



    }
}
