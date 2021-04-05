using InmobiliariasHomeCo.Entities.Grid.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Abstract.Grid.Consultas
{
    public interface IDataAccessGrid
    {
        GridConsultas[] GetGridConsultas();
    }
}
