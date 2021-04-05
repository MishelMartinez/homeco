using InmobiliariasHomeCo.Abstract.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Searchs;

namespace InmobiliariasHomeCo.Concret.Mock.Search
{
    class DataAccessTypeOfOperationMock : IDataAccessTypeOfOperation
    {
        public TypeOfOperation[] GetTypeOfOperation()
        {
            return new TypeOfOperation[]
            {
                new TypeOfOperation()
                {
                    Id =1 ,
                    Description = "RENTA"
                },
                 new TypeOfOperation()
                {
                    Id =1 ,
                    Description = "VENTA"
                },

            };
        }
    }
}
