using System;
namespace InmobiliariasHomeCo.Entities.Properties.Locations
{
    public class State
    {
        public int      IdState     { get; set; }
        public string   Name        { get; set; }
        public Country  Country     { get; set; }
    }
}
