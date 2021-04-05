using System;
namespace RealEstateHomeCo.Entities.Validations
{
    public class Rol
    {
        public int      IdRol       { get; set; }
        public string   Name        { get; set; }
        public string   Description { get; set; }
        public bool     IsAdmin     { get; set; }
    }
}
