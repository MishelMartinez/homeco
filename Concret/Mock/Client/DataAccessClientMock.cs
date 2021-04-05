using InmobiliariasHomeCo.Abstract.Catalogs;
using InmobiliariasHomeCo.Entities.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Concret.Mock.Client
{
    public class DataAccessClientMock : IDataAccessPerson
    {
        public Person[] GetPersons()
        {
            throw new NotImplementedException();
        }

        public Person InsertPerson(Person person)
        {
            throw new NotImplementedException();
        }


    }
}
