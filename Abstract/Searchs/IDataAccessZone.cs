using InmobiliariasHomeCo.Entities.Searchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Searchs
{
    public interface IDataAccessZone
    {
        Zone[]  GetZone();
    }
}
