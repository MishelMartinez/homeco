using InmobiliariasHomeCo.Entities.Locations;
using InmobiliariasHomeCo.Entities.Validations.MaritalStatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Entities.Persons
{
    public class Person
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string MobilNumber { get; set; }
        public string Email { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime BirthDate { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public int ChildrenNUmber { get; set; }
    }
}
