using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Concret.Mock.Search
{
    class DataAccessStateMock : IDataAccessState
    {
        public States[] GetState()
        {
            return new States[]
          {
                new States()
                {
                    Id     =    1 ,
                    State  =    "Estado de Mexico"
                },
                 new States()
                {
                    Id     =     2 ,
                    State  =    "Jalisco"
                },
                 new States()
                {
                    Id     =     3 ,
                    State  =    "Oaxaca"
                },
                 new States()
                {
                    Id     =     4 ,
                    State  =    "Guanajuato"
                },
                 new States()
                {
                    Id     =     5 ,
                    State  =    "Puebla"
                },
                new States()
                {
                    Id     =     6 ,
                    State  =    "Jalisco"
                },
                 new States()
                {
                    Id     =     7 ,
                    State  =    "Michoacan"
                },
                  new States()
                {
                    Id     =     8 ,
                    State  =    "Baja California"
                },

          };
        }
    }
}
