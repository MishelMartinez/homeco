using System;
namespace RealEstateHomeCo.Entities.Validations
{
    public class Colony
    {
        public int    IdColony  { get; set; }
        public int    IdCity    { get; set; }
        public string Name      { get; set; }
        public string PostCode  { get; set; }
        public int    ZoneID    { get; set; }
    }
}
