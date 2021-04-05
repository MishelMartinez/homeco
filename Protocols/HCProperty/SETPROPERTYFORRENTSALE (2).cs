using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.HCProperty
{
    public class SETPROPERTYFORRENTSALE : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
           
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;
            string año = commandInfo.CaptureDate.Substring(0, 4);
            string mes = commandInfo.CaptureDate.Substring(5, 2);
            string dia = commandInfo.CaptureDate.Substring(8, 2);

            int FretsSoap1=0;
            if (commandInfo.FretsSoap == "true")  {  FretsSoap1 = 1; }  else {
            if (commandInfo.FretsSoap == "false") {  FretsSoap1 = 0; }}
            int TvRoom1 = 0;
            if (commandInfo.TvRoom == "true")  { TvRoom1 = 1; }  else {
            if (commandInfo.TvRoom == "false") { TvRoom1 = 0; }}
            int StudyRoom1 = 0;
            if (commandInfo.StudyRoom == "true")  {  StudyRoom1 = 1; }  else {
            if (commandInfo.StudyRoom == "false") {  StudyRoom1 = 0; }}
            int Bar1 = 0;
            if (commandInfo.Bar == "true")  {  Bar1 = 1; }  else {
            if (commandInfo.Bar == "false") {  Bar1 = 0; }}
            int ServiceYard1 = 0;
            if (commandInfo.ServiceYard == "true")  { ServiceYard1 = 1; }  else {
            if (commandInfo.ServiceYard == "false") { ServiceYard1 = 0; }}
            int MultipleSalon1 = 0;
            if (commandInfo.MultipleSalon == "true")  { MultipleSalon1 = 1; }  else {
            if (commandInfo.MultipleSalon == "false") { MultipleSalon1 = 0; }}
            int Smokestack1 = 0;
            if (commandInfo.Smokestack == "true")  { Smokestack1 = 1; }  else {
            if (commandInfo.Smokestack == "false") { Smokestack1 = 0; }}
            int Jacuzzi1 = 0;
            if (commandInfo.Jacuzzi  == "true")  { Jacuzzi1 =  1; }  else {
            if (commandInfo.Jacuzzi  == "false") { Jacuzzi1  = 0; }}
            int Vat1 = 0;
            if (commandInfo.Vat == "true")   {  Vat1 = 1; }  else {
            if (commandInfo.Vat == "false")  {  Vat1 = 0; }}
            int Lido1 = 0;
            if (commandInfo.Lido == "true")  { Lido1 = 1; }  else {
            if (commandInfo.Lido == "false") { Lido1 = 0; }}
            int CommonArea1 = 0;
            if (commandInfo.CommonArea == "true")  { CommonArea1 = 1; }  else {
            if (commandInfo.CommonArea == "false") { CommonArea1 = 0; }}
            int Terrace1 = 0;
            if (commandInfo.Terrace == "true")  {Terrace1 = 1; }  else {
            if (commandInfo.Terrace == "false") {Terrace1 = 0; }}
            int HouseClub1 = 0;
            if (commandInfo.HouseClub ==  "true")  { HouseClub1 = 1; }  else {
            if (commandInfo.HouseClub  == "false") { HouseClub1  = 0; }}
            int Garden1 = 0;
            if (commandInfo.Garden == "true")  { Garden1 = 1; }  else {
            if (commandInfo.Garden == "false") { Garden1 = 0; }}
            int Kitchen1 = 0;
            if (commandInfo.Kitchen == "true")  {Kitchen1 = 1; }  else {
            if (commandInfo.Kitchen == "false") {Kitchen1 = 0; }}
            int Spit1 = 0;
            if (commandInfo.Spit == "true")  { Spit1 = 1; }  else {
            if (commandInfo.Spit == "false") { Spit1 = 0; }}
            int SportFields1 = 0;
            if (commandInfo.Spit == "true")  { SportFields1 = 1; }  else {
            if (commandInfo.Spit == "false") { SportFields1 = 0; }}




            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.SetPropertyForRentSale(

                    int.Parse(commandInfo.CityKey),              //99   int
                string.Concat(commandInfo.Street),               //6    VARCHAR(80)
                    int.Parse(commandInfo.Id_Colony),            //3    int
                string.Concat(commandInfo.PostCode),             //5    int
                string.Concat(commandInfo.OutdoorNumber),        //7    VARCHAR(15)
                string.Concat(commandInfo.InteriorNumber),       //8    VARCHAR(15)
                string.Concat(commandInfo.CaptureDate),          //100  datetime
                string.Concat(mes),
                string.Concat(dia),
                    int.Parse(commandInfo.Id_Address),           //--
                    int.Parse(commandInfo.Id_Owner),             //2    int
                    int.Parse(commandInfo.Id_SalesRep),          //1    int 
                    int.Parse(commandInfo.Id_Ground),            //41   int
                    int.Parse(commandInfo.Area),                 //39   decimal
                    int.Parse(commandInfo.GardenArea),           //46   decimal
                    int.Parse(commandInfo.Construction),         //40   decimal
                    int.Parse(commandInfo.Levels),               //45   int
                    int.Parse(commandInfo.Front),                //43   decimal
                    int.Parse(commandInfo.BackGround),           //44   decimal
                string.Concat(commandInfo.Description),          //48   VARCHAR(4096)
                    int.Parse(commandInfo.AntiguatyYears),       //42   int
                string.Concat(commandInfo.Tank),                 //71   BIT		
                    int.Parse(commandInfo.CapacityTank),         //72   DECIMAL
                string.Concat(commandInfo.CurrentPredial),       //36   bit
                string.Concat(commandInfo.CurrentMaintenance),   //11   bit
                string.Concat(commandInfo.ServicesPayed),        //30   bit
                    int.Parse(commandInfo.Id_Currency),          //10   int
                string.Concat(commandInfo.FiscalReceipt),        //50   bit
                    int.Parse(commandInfo.Id_PropertyType),      //27   int
                    int.Parse(commandInfo.Id_PropertySubType),   //28   int
                string.Concat(commandInfo.Others),               //101  VARCHAR(255)
                    int.Parse(commandInfo.TypeOperation),        //102  int
                    SportFields1,          //94   int
                    Spit1,                 //76   int
                    int.Parse(commandInfo.Rooms),                //66   int
                    int.Parse(commandInfo.Closet),               //67   int
                    int.Parse(commandInfo.DressingRoom),         //68   int
                    int.Parse(commandInfo.Bath),                 //69   int
                    int.Parse(commandInfo.MiddleBath),           //70   int
                    int.Parse(commandInfo.ServiceCorridor),      //60   int
                    int.Parse(commandInfo.ServiceRoom),          //63   int
                    int.Parse(commandInfo.Parking),              //64   int
                    int.Parse(commandInfo.ParkingVisit),         //65   int
                    int.Parse(commandInfo.Cellar),               //62   int
                    Kitchen1,              //59   int
                    FretsSoap1,            //75   int
                    TvRoom1,               //77   int
                    StudyRoom1,            //79   int
                    Bar1,                  //81   int
                    ServiceYard1,          //93   int
                    MultipleSalon1,        //96   int
                    Smokestack1,           //82   int
                    Jacuzzi1,              //84   int
                    Vat1,                  //86   int
                    Lido1,                 //90   int
                    CommonArea1,           //95   int
                    HouseClub1,            //98   int
                    Terrace1,              //74   int
                    Garden1,               //73   int
                    int.Parse(commandInfo.MonthlyRent),          //9    Decimal
                string.Concat(commandInfo.Conditions),           //--
                    int.Parse(commandInfo.DepositsMonths),       //12   int
                    int.Parse(commandInfo.Amount),               //19   Decimal
                    int.Parse(commandInfo.PriceM2),              //20   Decimal
                string.Concat(commandInfo.FreeDocument),         //52   bit
                string.Concat(commandInfo.DocumentNumber),       //51   varchar(30)
                string.Concat(commandInfo.CurrentCredit),        //55   bit
                    int.Parse(commandInfo.BalanceCredit),        //54   Decimal
                string.Concat(commandInfo.AssessmentFree),       //53   bit
                string.Concat(commandInfo.SaleInLast3years),     //56   bit
                string.Concat(commandInfo.OtherLegalStatus),     //58   varchar(1024)
                string.Concat(commandInfo.LightService),         //31   bit
                string.Concat(commandInfo.WaterService),         //34   bit
                string.Concat(commandInfo.Lamps),                //78   bit
                string.Concat(commandInfo.GasService),           //37   bit
                string.Concat(commandInfo.SewerSystem),          //32   bit
                string.Concat(commandInfo.TelephoneService),     //35   bit
                string.Concat(commandInfo.CableService),         //38   bit
                string.Concat(commandInfo.Alarm),                //87   bit
                string.Concat(commandInfo.ElectricFence),        //89   bit
                string.Concat(commandInfo.Policy),               //91   bit
                string.Concat(commandInfo.IrrigationSystem),     //97   bit
                string.Concat(commandInfo.Nets),                 //80   bit
                string.Concat(commandInfo.Blinds),               //83   bit
                string.Concat(commandInfo.Curtains),             //85   bit
                string.Concat(commandInfo.WaterPressure),        //88   bit
                string.Concat(commandInfo.AirConditioner),       //92   bit
                string.Concat(commandInfo.TaxReceipt),           //13   bit
                string.Concat(commandInfo.Furnished),            //14   bit
                string.Concat(commandInfo.Guarantor),            //15   bit
                string.Concat(commandInfo.LegalPolicy),          //16   bit
                string.Concat(commandInfo.Other1),               //17   bit
                string.Concat(commandInfo.DeliveryPeriod),       //21   varchar(200)
                    int.Parse(commandInfo.Advance),              //22   Decimal
                string.Concat(commandInfo.Builder),              //23   bit
                string.Concat(commandInfo.Development),          //24   bit
                string.Concat(commandInfo.DirectOwner),          //25   bit
                string.Concat(commandInfo.Other),                //26   bit
                string.Concat(commandInfo.MimeType),             //103  varchar(100)
                string.Concat(commandInfo.Principal),            //104  bit			
                string.Concat(commandInfo.Description1),         //105  varchar(max)
                string.Concat(commandInfo.Url),                  //106  varchar(max)
                string.Concat(commandInfo.Private)               //29   bit
                )));
            Console.WriteLine("Protocolo alcanzado");
        }
    }
}
