using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Validations
{
    public partial class zone
    {
        public int Id_Country { get; set; }
        public int Id_State { get; set; }
    }

    public class Zone_Validations
    {
        public int zone_id { get; set; }

        public int zone_name { get; set; }

        public int Id_Country { get; set; }

        public int Id_State { get; set; }

        public int Id_City { get; set; }
    }
}
