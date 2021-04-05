using System;
namespace RealEstateHomeCo.Entities.Validations
{
    public partial class Properties
    {
        public virtual int IdCountry        { get; set; }
        public virtual int IdState          { get; set; }
    }

    public class Estate
    {
        public int          IdProperty      { get; set; }
        public string       PropertyKey     { get; set; }
        public DateTime     FechaCaptura    { get; set; }
        public int          IdCountry       { get; set; }
        public int          IdState         { get; set; }
        public int          IdCity          { get; set; }
        public int          IdZone          { get; set; }
        public int          IdLocality      { get; set; }
        public string       OperationType   { get; set; }
        public byte         IdSector        { get; set; }
        public int          IdProdCat       { get; set; }
        public int          IdProduct       { get; set; }
        public decimal      Commission      { get; set; }
        public int          IdSalesRep      { get; set; }
        public decimal      AmountRent      { get; set; }
        public decimal      AmountBuy       { get; set; }
        public byte         Stat            { get; set; }
        public decimal      FinalPrc        { get; set; }
        public int          IdSalesFinal    { get; set; }
        public string       Street          { get; set; }
        public int          IdColony        { get; set; }
        public string       PostCode        { get; set; }
        public string       Number          { get; set; }
        public string       InteriorNumber  { get; set; }
        public string       Surface         { get; set; }
        public byte         IdRegion        { get; set; }
        public byte         IdGround        { get; set; }
        public string       Conditions      { get; set; }
        public bool         Maintenance     { get; set; }
        public byte         MonthDeposit    { get; set; }
        public bool         FiscalReceipt   { get; set; }
        public bool         Furnished       { get; set; }
        public bool         Bailor          { get; set; }
        public bool         LegalPolicy     { get; set; }
        public string       Other           { get; set; }
        public bool         IsPrivate       { get; set; }
        public bool         Services        { get; set; }


        public bool         Provisional         { get; set; }
        public bool         CurrentPredial      { get; set; }
        public bool         CurrentMaintenance  { get; set; }
        public bool         LightService        { get; set; }
        public bool         WaterService        { get; set; }
        public bool         GasService          { get; set; }
        public bool         SewerSystem         { get; set; }
        public bool         TelService          { get; set; }
        public bool         CableService        { get; set; }
        public decimal      Area                { get; set; }
        public decimal      Construction        { get; set; }
        public int          Antique             { get; set; }
        public decimal      Front               { get; set; }
        public decimal      BackGround          { get; set; }
        public byte         Levels              { get; set; }
        public decimal      Garden              { get; set; }
        public string       OtherCharac         { get; set; }
        public bool         Kitchen             { get; set; }
        public byte         KitchenStat         { get; set; }
        public string       Housing             { get; set; }
        public bool         FretsSoap           { get; set; }
        public bool         TvRoom              { get; set; }
        public bool         Study               { get; set; }
        public bool         Bar                 { get; set; }
        public bool         Rooms               { get; set; }
        public byte         NumRooms            { get; set; }
        public bool         Closet              { get; set; }
        public byte         NumCloset           { get; set; }
        public bool         DressingRoom        { get; set; }
        public byte         NumDressingRom      { get; set; }
        public bool         Bath                { get; set; }
        public byte         NumBath             { get; set; }
        public bool         MiddleBath          { get; set; }
        public byte         NumMiddleBath       { get; set; }
        public bool         ServiceYard         { get; set; }
        public bool         MultipleSalon       { get; set; }
        public bool         ServiceCorridor     { get; set; }
        public byte         NumServiceCorridor  { get; set; }
        public bool         Cellar              { get; set; }
        public byte         NumCellar           { get; set; }
        public bool         ServiceRoom         { get; set; }

        public Nullable<byte> NumServiceRoom    { get; set; }

        public bool Parking { get; set; }

        public Nullable<byte> NumParking { get; set; }

        public bool ParkingVisit { get; set; }

        public Nullable<byte> NumParkingVisit { get; set; }

        public bool Smokestack { get; set; }

        public bool Jacuzzi { get; set; }

        public bool Vat { get; set; }
  
        public bool Alarm { get; set; }

        public bool ElectricFence { get; set; }
        // Preguntar si con Policy se refieren a seguridad

        public bool Policy { get; set; }
 
        // Preguntar a que hacen referencia con spotsfields
        public bool SpotsFields { get; set; }

        public bool IrrigationSystem { get; set; }

        public bool Garden1 { get; set; }

        public bool Terrace { get; set; }

        public bool Spit { get; set; }

        public bool Lamps { get; set; }

        // Preguntar a que se refieren con "Nets" (redes)?
        public bool Nets { get; set; }

        public bool Blinds { get; set; }

        public bool Curtains { get; set; }

        public bool Tank { get; set; }

        public decimal CapacityTank { get; set; }

        public bool WaterPressure { get; set; }

        public bool canchasDeportivas { get; set; }

        public bool lido { get; set; }
  
        public string CaracteristicasPiscina { get; set; }
       
        public bool AirConditioner { get; set; }

        public bool CommonArea { get; set; }
       
        public bool HouseClub { get; set; }

        public string Description { get; set; }
 
        public int Id_Owner { get; set; }

        public int Id_Currency { get; set; }

        public int PrecioM2 { get; set; }

        public string Entrega { get; set; }

        public decimal AnticipoVenta { get; set; }

        public decimal TipoVendedor { get; set; }

        public decimal OtroTipoVendedor { get; set; }

        public bool EscrituraLiberada { get; set; }

        public string NumEscritura { get; set; }

        public bool CreditoVigente { get; set; }
  
        public Nullable<decimal> DeudaCredito { get; set; }

        public bool LibreGravamen { get; set; }

        public bool ServiciosAlCorriente { get; set; }

        public bool VentaUltimos3anhos { get; set; }

        public bool ConoceLeyAntilavado { get; set; }

        public string OtroEstatusLegal { get; set; }
    }
}
