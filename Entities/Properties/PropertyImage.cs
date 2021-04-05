using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Properties
{
    public class PropertyImage
    {
        public int      Id              { get; set; }
        public string   MimeType        { get; set; }
        public bool     Principal       { get; set; }
        public string   Description     { get; set; }
        public string   Url             { get; set; }
    }
}
