using System;
namespace InmobiliariasHomeCo.Entities.Properties.Locations
{
    public class Zone
    {
        public int      IdZone      { get; set; }
        public string   Name        { get; set; }
        public City     IdCity      { get; set; }
    }
}
