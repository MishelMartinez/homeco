using System;
using InmobiliariasHomeCo.Entities.Persons;

namespace InmobiliariasHomeCo.Abstract.Catalogs
{
    public interface IDataAccessPerson
    {
        Person InsertPerson(Person person);
        Person[] GetPersons();
    }
}
