using System;
namespace InmobiliariasHomeCo.Entities.Properties.Locations
{
    public class Colony
    {
        public int      IdColony      { get; set; }
        public string   Name          { get; set; }
        public string   CodePost      { get; set; }
        public City     City        { get; set; } 

    }
}
