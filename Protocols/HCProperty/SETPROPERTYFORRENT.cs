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
    public class SETPROPERTYFORRENT : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            int FretsSoap1 = 0;
            if (commandInfo.FretsSoap == "true") { FretsSoap1 = 1; }
            else
            {
                if (commandInfo.FretsSoap == "false") { FretsSoap1 = 0; }
            }
            int TvRoom1 = 0;
            if (commandInfo.TvRoom == "true") { TvRoom1 = 1; }
            else
            {
                if (commandInfo.TvRoom == "false") { TvRoom1 = 0; }
            }
            int StudyRoom1 = 0;
            if (commandInfo.StudyRoom == "true") { StudyRoom1 = 1; }
            else
            {
                if (commandInfo.StudyRoom == "false") { StudyRoom1 = 0; }
            }
            int Bar1 = 0;
            if (commandInfo.Bar == "true") { Bar1 = 1; }
            else
            {
                if (commandInfo.Bar == "false") { Bar1 = 0; }
            }
            int ServiceYard1 = 0;
            if (commandInfo.ServiceYard == "true") { ServiceYard1 = 1; }
            else
            {
                if (commandInfo.ServiceYard == "false") { ServiceYard1 = 0; }
            }
            int MultipleSalon1 = 0;
            if (commandInfo.MultipleSalon == "true") { MultipleSalon1 = 1; }
            else
            {
                if (commandInfo.MultipleSalon == "false") { MultipleSalon1 = 0; }
            }
            int Smokestack1 = 0;
            if (commandInfo.Smokestack == "true") { Smokestack1 = 1; }
            else
            {
                if (commandInfo.Smokestack == "false") { Smokestack1 = 0; }
            }
            int Jacuzzi1 = 0;
            if (commandInfo.Jacuzzi == "true") { Jacuzzi1 = 1; }
            else
            {
                if (commandInfo.Jacuzzi == "false") { Jacuzzi1 = 0; }
            }
            int Vat1 = 0;
            if (commandInfo.Vat == "true") { Vat1 = 1; }
            else
            {
                if (commandInfo.Vat == "false") { Vat1 = 0; }
            }
            int Lido1 = 0;
            if (commandInfo.Lido == "true") { Lido1 = 1; }
            else
            {
                if (commandInfo.Lido == "false") { Lido1 = 0; }
            }
            int CommonArea1 = 0;
            if (commandInfo.CommonArea == "true") { CommonArea1 = 1; }
            else
            {
                if (commandInfo.CommonArea == "false") { CommonArea1 = 0; }
            }
            int Terrace1 = 0;
            if (commandInfo.Terrace == "true") { Terrace1 = 1; }
            else
            {
                if (commandInfo.Terrace == "false") { Terrace1 = 0; }
            }
            int HouseClub1 = 0;
            if (commandInfo.HouseClub == "true") { HouseClub1 = 1; }
            else
            {
                if (commandInfo.HouseClub == "false") { HouseClub1 = 0; }
            }
            int Garden1 = 0;
            if (commandInfo.Garden == "true") { Garden1 = 1; }
            else
            {
                if (commandInfo.Garden == "false") { Garden1 = 0; }
            }
            int Kitchen1 = 0;
            if (commandInfo.Kitchen == "true") { Kitchen1 = 1; }
            else
            {
                if (commandInfo.Kitchen == "false") { Kitchen1 = 0; }
            }
            int Spit1 = 0;
            if (commandInfo.Spit == "true") { Spit1 = 1; }
            else
            {
                if (commandInfo.Spit == "false") { Spit1 = 0; }
            }
            int SportFields1 = 0;
            if (commandInfo.Spit == "true") { SportFields1 = 1; }
            else
            {
                if (commandInfo.Spit == "false") { SportFields1 = 0; }
            }


            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.SetPropertyForRent(

                    int.Parse(commandInfo.CityKey),
                string.Concat(commandInfo.Street),
                    int.Parse(commandInfo.Id_Colony),
                string.Concat(commandInfo.PostCode),
                string.Concat(commandInfo.OutdoorNumber),
                string.Concat(commandInfo.InteriorNumber),
                string.Concat(commandInfo.CaptureDate),
                    int.Parse(commandInfo.Id_Address),
                    int.Parse(commandInfo.Id_Owner),
                    int.Parse(commandInfo.Id_SalesRep),
                    int.Parse(commandInfo.Id_Ground),
                    int.Parse(commandInfo.Area),
                    int.Parse(commandInfo.GardenArea),
                    int.Parse(commandInfo.Construction),
                    int.Parse(commandInfo.Levels),
                    int.Parse(commandInfo.Front),
                    int.Parse(commandInfo.BackGround),
                string.Concat(commandInfo.Description),
                    int.Parse(commandInfo.AntiguatyYears),
                string.Concat(commandInfo.Tank),
                    int.Parse(commandInfo.CapacityTank),
                string.Concat(commandInfo.CurrentPredial),
                string.Concat(commandInfo.CurrentMaintenance),
                string.Concat(commandInfo.ServicesPayed),
                    int.Parse(commandInfo.Id_Currency),
                string.Concat(commandInfo.FiscalReceipt),
                    int.Parse(commandInfo.Id_PropertyType),
                    int.Parse(commandInfo.Id_PropertySubType),
                string.Concat(commandInfo.Others),
                    int.Parse(commandInfo.TypeOperation),
                    SportFields1,          //94   int
                    Spit1,                 //76   int
                    int.Parse(commandInfo.Rooms),
                    int.Parse(commandInfo.Closet),
                    int.Parse(commandInfo.DressingRoom),
                    int.Parse(commandInfo.Bath),
                    int.Parse(commandInfo.MiddleBath),
                    int.Parse(commandInfo.ServiceCorridor),
                    int.Parse(commandInfo.ServiceRoom),
                    int.Parse(commandInfo.Parking),
                    int.Parse(commandInfo.ParkingVisit),
                    int.Parse(commandInfo.Cellar),
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
                    int.Parse(commandInfo.MonthlyRent),
                string.Concat(commandInfo.Conditions),
                    int.Parse(commandInfo.DepositsMonths),
                string.Concat(commandInfo.LightService),
                string.Concat(commandInfo.WaterService),
                string.Concat(commandInfo.Lamps),
                string.Concat(commandInfo.GasService),
                string.Concat(commandInfo.SewerSystem),
                string.Concat(commandInfo.TelephoneService),
                string.Concat(commandInfo.CableService),
                string.Concat(commandInfo.Alarm),
                string.Concat(commandInfo.ElectricFence),
                string.Concat(commandInfo.Policy),
                string.Concat(commandInfo.IrrigationSystem),
                string.Concat(commandInfo.Nets),
                string.Concat(commandInfo.Blinds),
                string.Concat(commandInfo.Curtains),
                string.Concat(commandInfo.WaterPressure),
                string.Concat(commandInfo.AirConditioner),
                string.Concat(commandInfo.TaxReceipt),
                string.Concat(commandInfo.Furnished),
                string.Concat(commandInfo.Guarantor),
                string.Concat(commandInfo.LegalPolicy),
                string.Concat(commandInfo.Other1),
                string.Concat(commandInfo.MimeType),
                string.Concat(commandInfo.Principal),
                string.Concat(commandInfo.Description1),
                string.Concat(commandInfo.Url),
                string.Concat(commandInfo.FreeDocument),
                string.Concat(commandInfo.DocumentNumber),
                string.Concat(commandInfo.CurrentCredit),
                    int.Parse(commandInfo.BalanceCredit),
                string.Concat(commandInfo.AssessmentFree),
                string.Concat(commandInfo.SaleInLast3years),
                string.Concat(commandInfo.OtherLegalStatus),
                string.Concat(commandInfo.Private)
                )));
        }
    }
}
