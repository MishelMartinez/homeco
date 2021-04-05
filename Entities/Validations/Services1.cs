using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Validations
{
    public class Services1
    {
        public int  IdEstate            { get; set; }
        public bool CurrentPredial      { get; set; }
        public bool CurrentMaintenance  { get; set; }
        public bool LightService        { get; set; }
        public bool WaterService        { get; set; }
        public bool GasService          { get; set; }
        public bool SewerSystem         { get; set; }
        public bool TelService          { get; set; }
        public bool CableService        { get; set; }
    }
}
