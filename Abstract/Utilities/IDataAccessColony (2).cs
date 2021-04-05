using RealEstateHomeCo.Entities.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Utilities
{
    public interface IDataAccessColony
    {
        Colony[] GetColonies();
    }
}
