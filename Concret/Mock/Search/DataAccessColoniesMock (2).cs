using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Concret.Mock.Search
{
    class DataAccessColoniesMock : IDataAccessColonies
    {
        public Colonies[] GetColonies()
        {
            return new Colonies[]
           {
                 new  Colonies() {
                      Id =1,
                      Colony ="Hola"
             },
           };
        }
    }
}
