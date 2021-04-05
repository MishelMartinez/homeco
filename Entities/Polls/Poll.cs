using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Polls
{
    public class Poll
    {
        /*
        public string FullName { get; set; }
        public string Phone     { get; set; }
        public string Email { get; set; }
        */
        public string Interests { get; set; }

        public int Alternative { get; set; }

        public int Price { get; set; }
        public int Spaces { get; set; }
        public int Ubication { get; set; }

        public int StateConservation { get; set; }

        public Boolean BuyProperty { get; set; }

        public string TextBuyProperty { get; set; }

        public string Observations { get; set; }


    }
}
