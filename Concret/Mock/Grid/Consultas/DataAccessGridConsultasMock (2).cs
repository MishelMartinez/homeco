using InmobiliariasHomeCo.Abstract.Grid.Consultas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Grid.Consultas;

namespace InmobiliariasHomeCo.Concret.Mock.Grid.Consultas
{
    public class DataAccessGridConsultasMock : IDataAccessGrid

    {
        public GridConsultas[] GetGridConsultas()
        {
            return new GridConsultas[]
            {
                new GridConsultas()
                {
                    Key = "MX14-AM9679",
                    Image="",
                    Property="CASA",
                    Cost="$16099MXN",
                    Operation="RENTA VENTA",
                    State="QUERETARO",
                    Commission="19%",
                    Status="PROMOCION"
                },
                 new GridConsultas()
                {
                    Key = "MX14-AM9679",
                    Image="",
                    Property="CASA",
                    Cost="$76899MXN",
                    Operation="VENTA RENTA",
                    State="QUERETARO",
                    Commission="19%",
                    Status="PROMOCION"
                },
                  new GridConsultas()
                {
                    Key = "MX65-AM9679",
                    Image="",
                    Property="CASA",
                    Cost="$76899MXN",
                    Operation="VENTA RENTA",
                    State="QUERETARO",
                    Commission="20%",
                    Status="PROMOCION"
                },
                   new GridConsultas()
                {
                    Key = "MX90-AM9679",
                    Image="",
                    Property="CASA",
                    Cost="$76899MXN",
                    Operation="VENTA RENTA",
                    State="QUERETARO",
                    Commission="35%",
                    Status="PROMOCION"
                },
            };

        }
    }
}
