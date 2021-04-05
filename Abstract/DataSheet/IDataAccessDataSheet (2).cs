using InmobiliariasHomeCo.Entities.DataSheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.DataSheets
{
   public  interface IDataAccessDataSheet
    {
        DataSheet[] GetDataSheet();
    }
}
