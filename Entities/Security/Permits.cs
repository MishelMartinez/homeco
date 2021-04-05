using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Security
{
    public  enum Permits
    {

        Mostrar             =   1,
        Editar              =   2,
        Agregar             =   4,
        Eliminar            =   8,
        AgregarComision     =   16,
        AgregarImagen       =   32,
        AgregarDescripcion  =   64,
        NuevoPermiso        =   128

    }
}
