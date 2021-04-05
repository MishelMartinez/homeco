using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Concret.Mock.Search
{
    class DataAccessMunicipalityMock : IDataAccessMunicipality

    {
        public Municipalities[] GetMunicipalities()
        {
            return new Municipalities[]
            {
                 new  Municipalities() {
                      Id =1,
                      Municipalitys ="Hola"
             },
            };
    }
    }
}
