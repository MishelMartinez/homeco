using InmobiliariasHomeCo.Entities.Locations;
using System;
namespace InmobiliariasHomeCo.Entities.Properties
{
    public class PropertyCharacteristics
    {
        public Service[]    Services           { get; set; }
        public Area[]       Areas              { get; set; }
        public Address      Address            { get; set; }
        public string       Description        { get; set; }
        public decimal      Construction       { get; set; }
        public int          AntiguatyYears     { get; set; }
        public decimal      Area               { get; set; }
        public int          Levels             { get; set; }
        public decimal      GardenArea         { get; set; }
        public bool         Tank               { get; set; }
        public decimal      CapacityTank       { get; set; }
        public bool         CurrentPredial     { get; set; }
        public bool         CurrentMaintenance { get; set; }
        public bool         ServicesPayed      { get; set; }
        public bool         FiscalReceipt      { get; set; }
        public string       Others             { get; set; }   
    }
}
