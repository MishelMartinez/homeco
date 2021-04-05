using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Concret.Mock.Search
{
    class DataAccessZoneMock : IDataAccessZone
    {
        public Zone[] GetZone()
        {
            return new Zone[]
           {
                 new  Zone() {
                  Id =1,
                  Areas ="Area"
                }
           };
            
    }
    }
}
