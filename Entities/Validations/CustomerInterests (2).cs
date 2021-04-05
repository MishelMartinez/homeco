using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Validations
{
    public class CustomerInterests
    {
        public int Id_Interests { get; set; }
        
        public int Id_Customer { get; set; }

        public decimal Budget { get; set; }

        public int Id_Currency { get; set; }

        public int Id_Product { get; set; }

        public byte Id_Sector { get; set; }

        public Nullable<int> Zone_Id { get; set; }

        public Nullable<byte> Tier { get; set; }

        public Nullable<byte> Room { get; set; }

        public string InterestsKey { get; set; }

        public string BuyKey { get; set; }

        public Nullable<byte> Id_Source { get; set; }
    }
}
