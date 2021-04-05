using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Validations
{
    public class Interiors1
    {
        public int      IdEstate            { get; set; }
        public bool     TvRoom              { get; set; }
        public bool     Study               { get; set; }
        public bool     Bar                 { get; set; }
        public bool     Rooms               { get; set; }
        public byte     NumRooms            { get; set; }
        public bool     Closet              { get; set; }
        public byte     NumCloset           { get; set; }
        public bool     DressingRoom        { get; set; }
        public byte     NumDressingRom      { get; set; }
        public bool     Bath                { get; set; }
        public byte     NumBath             { get; set; }
        public bool     MiddleBath          { get; set; }
        public byte     NumMiddleBath       { get; set; }
        public bool     Kitchen             { get; set; }
        public byte     KitchenStat         { get; set; }

        public bool     Cellar              { get; set; }
        public byte     NumCellar           { get; set; }
        public bool     ServiceRoom         { get; set; }

        public bool     Smokestack          { get; set; }
        public bool     Jacuzzi             { get; set; }
        public bool     Vat                 { get; set; }
        public bool     Alarm               { get; set; }
        public bool     AirConditioner      { get; set; }

        public bool     FretsSoap           { get; set; }
    }
}
