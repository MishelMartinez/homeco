using System;
using System.Collections.Generic;
using InmobiliariasHomeCo.Entities.Currencies;
using InmobiliariasHomeCo.Entities.Locations;
using InmobiliariasHomeCo.Entities.Persons.Owners;
using InmobiliariasHomeCo.Entities.Properties.Locations;

namespace InmobiliariasHomeCo.Entities.Properties
{
    public  class Property
    {
        public int                     IdProperty      { get; set; }
        public string                  PropertyKey     { get; set; }
        public DateTime                CaptureDate     { get; set; }
        public Currency                Currency        { get; set; }
        public PropertyCharacteristics Characteristics { get; set; }
        public PropertyImage []        PropertyImages  { get; set; }
        public Owner                   Owner           { get; set; }
    }
}

