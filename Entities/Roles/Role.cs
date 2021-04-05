using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Roles
{
    public class Role
    {
        public int      IdRole          { get; set; }
        public string   Name            { get; set; }
        public string   Description     { get; set; }

        public Boolean  Status          { get; set; }
    }
}
