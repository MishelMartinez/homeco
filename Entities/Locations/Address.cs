using System;
using InmobiliariasHomeCo.Entities.Properties.Locations;

namespace InmobiliariasHomeCo.Entities.Locations
{
    public class Address
    {
        public int     Id                { get; set; }
        public Colony  Colony            { get; set; }
        public City    City              { get; set; }
        public Country Country           { get; set; }
        public string  PostCode          { get; set; }
        public string  Street            { get; set; }
        public string  OutdoorNumber     { get; set; }
        public string  InteriorNumber    { get; set; }
    }


}
