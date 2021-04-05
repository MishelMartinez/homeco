using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Concret.Mock.Searchs
{
    class DataAccessPropertyTypeMock : IDataAccessPropertyType
    {
     

        public PropertyType[] GetPropertyType()
        {
            return new PropertyType[] 
            {
                new PropertyType () {
                    Id =1 ,
                    Description = "CASA"
                },
                new PropertyType () {
                    Id =2 ,
                    Description = "DEPARTAMENTO"
                },
                new PropertyType () {
                    Id =3 ,
                    Description = "TERRENO"
                },
                new PropertyType () {
                    Id =4 ,
                    Description = "FINCA/RANCHO"
                },
                new PropertyType () {
                    Id =5 ,
                    Description = "COMERCIAL"
                },
                new PropertyType () {
                    Id =6 ,
                    Description = "BODEGA"
                },
                new PropertyType () {
                    Id =7 ,
                    Description = "LOCAL"
                },

            };

        }
    }
}
