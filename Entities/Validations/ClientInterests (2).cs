using System;
namespace RealEstateHomeCo.Entities.Validations
{
    public partial class CustomerInterests
    {
    }

    public class ClientInterests
    {
        public int              IdInterests     { get; set; }
        public int              IdCustomer      { get; set; }
        public decimal          Budget          { get; set; }
        public int              IdCurrency      { get; set; }
        public int              IdProduct       { get; set; }
        public byte             IdSector        { get; set; }
        public Nullable<int>    ZoneId          { get; set; }
        public Nullable<byte>   Tier            { get; set; }
        public Nullable<byte>   Room            { get; set; }
        public string           InterestsKey    { get; set; }
        public string           BuyKey          { get; set; }
        public Nullable<byte>   IdSource        { get; set; }

       
    }
}
