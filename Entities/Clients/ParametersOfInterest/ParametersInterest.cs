using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Clients.ParametersOfInterest
{
    public class ParametersInterest
    {

        public double  MaximumBudget           { get; set; }

       
        public int  Coin                    { get; set; }

        public int  TypeProperty             { get; set; }

        public int  Sector                  { get; set; }

        public int  Zone                    { get; set; }

        public int Levels                   { get; set; }

        public int Bedrooms                 { get; set; }

        public KeyInterest [] keyInterest   { get; set; }

        public KeyShopping[] keyShopping    { get; set; }
            
        public Origin  Origin                 { get; set; }








    }
}
