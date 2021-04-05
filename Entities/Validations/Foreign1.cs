using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Validations
{
    public class Foreign1
    {
        public int            IdEstate     { get; set; }
        public byte           Levels       { get; set; }
        public decimal        Garden       { get; set; }
        public string         OtherCharac  { get; set; }
        public string         Housing      { get; set; }
        public bool           ServiceYard         { get; set; }
        public bool           MultipleSalon       { get; set; }
        public bool           ServiceCorridor     { get; set; }
        public byte           NumServiceCorridor  { get; set; }

        public Nullable<byte> NumServiceRoom { get; set; }
        public bool           Parking        { get; set; }
        public Nullable<byte> NumParking     { get; set; }
        public bool           ParkingVisit   { get; set; }
        public Nullable<byte> NumParkingVisit{ get; set; }

        public bool           IrrigationSystem { get; set; }
        public bool           SpotsFields    { get; set; }

        public bool           Garden1        { get; set; }
        public bool           Terrace        { get; set; }
        public bool           Spit           { get; set; }

        public bool           Lamps         { get; set; }
        public bool           Nets          { get; set; }
        public bool           Blinds        { get; set; }
        public bool           Curtains      { get; set; }
        public bool           Tank          { get; set; }
        public decimal        CapacityTank  { get; set; }
        public bool           WaterPressure { get; set; }

        public bool           canchasDeportivas { get; set; }
        public bool           lido { get; set; }
        public string         CaracteristicasPiscina { get; set; }

        public bool           CommonArea { get; set; }
        public bool           HouseClub { get; set; }

        public bool           ElectricFence { get; set; }
    }
}
