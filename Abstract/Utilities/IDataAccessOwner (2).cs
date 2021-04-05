using InmobiliariasHomeCo.Entities.Persons.Owners;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Utilities
{
    public interface IDataAccessOwner
    {
        Owner[] GetOwners();
        Owner InsertOwner(Owner owner);
    }
}
