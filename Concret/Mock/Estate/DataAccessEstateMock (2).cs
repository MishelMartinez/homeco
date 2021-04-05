using InmobiliariasHomeCo.Abstract.Catalogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateHomeCo.Entities.Validations;
using System.Data.SqlClient;
using System.Data;

namespace InmobiliariasHomeCo.Concret.Mock.Estates
{
    public class DataAccessEstateMock : IDataAccessEstate
    {
        public Estate[] GetEstate()
        {
            throw new NotImplementedException();
        }

        /*
public Estate[] GetEstate()
{
   throw new NotImplementedException();
}
*/

        public Estate InsertEstate(Estate estate)
        {
            estate = new Estate()
            {
                //PropertyKey             = "dsds",
                FechaCaptura            = DateTime.Parse("2017-07-18"),
                IdCountry               = 1,
                IdState                 = 1,
                IdCity                  = 1,
                IdZone                  = 1,
                IdLocality              = 1,
                OperationType           = "Renta",
                IdSector                = byte.Parse("1"),
                IdProdCat               = 1,
                IdProduct               = 1,
                Commission              = decimal.Parse("1"),
                IdSalesRep              = 1,
                AmountRent              = decimal.Parse("1"),
                AmountBuy               = decimal.Parse("1"),
                Stat                    = byte.Parse("1"),
                FinalPrc                = decimal.Parse("1"),
                IdSalesFinal            = 1,
                Street                  = "1",
                IdColony                = 1,
                PostCode                = "1",
                Number                  = "1",
                InteriorNumber          = "1",
                Surface                 = "1",
                IdRegion                = byte.Parse("1"),
                IdGround                = byte.Parse("1"),
                Conditions              = "1",
                Maintenance             = true,
                MonthDeposit            = byte.Parse("1"),
                FiscalReceipt           = true,
                Furnished               = true,
                Bailor                  = true,
                LegalPolicy             = true,
                Other                   = "1",
                IsPrivate               = true,
                Services                = true,
                Provisional             = true,
                CurrentPredial          = true,
                CurrentMaintenance      = true,
                LightService            = true,
                WaterService            = true,
                GasService              = true,
                SewerSystem             = true,
                TelService              = true,
                CableService            = true,
                Area                    = decimal.Parse("1"),
                Construction            = decimal.Parse("1"),
                Antique                 = 1,
                Front                   = decimal.Parse("1"),
                BackGround              = decimal.Parse("1"),
                Levels                  = byte.Parse("1"),
                Garden                  = decimal.Parse("1"),
                OtherCharac             = "Obviamente",
                Kitchen                 = true,
                KitchenStat             = byte.Parse("1"),
                Housing                 = "1",
                FretsSoap               = true,
                TvRoom                  = true,
                Study                   = true,
                Bar                     = true,
                Rooms                   = true,
                NumRooms                = byte.Parse("1"),
                Closet                  = true,
                NumCloset               = byte.Parse("1"),
                DressingRoom            = false,
                NumDressingRom          = byte.Parse("1"),
                Bath                    = true,
                NumBath                 = byte.Parse("1"),
                MiddleBath              = true,
                NumMiddleBath           = byte.Parse("1"),
                ServiceYard             = true,
                MultipleSalon           = true,
                ServiceCorridor         = true,
                NumServiceCorridor      = byte.Parse("1"),
                Cellar                  = true,
                NumCellar               = byte.Parse("1"),
                ServiceRoom             = true,
                NumServiceRoom          = byte.Parse("1"),
                Parking                 = true,
                NumParking              = byte.Parse("1"),
                ParkingVisit            = true,
                NumParkingVisit         = byte.Parse("1"),
                Smokestack              = true,
                Jacuzzi                 = true,
                Vat                     = true,
                Alarm                   = true,
                ElectricFence           = true,
                Policy                  = true,
                SpotsFields             = true,
                IrrigationSystem        = true,
                Garden1                 = true,
                Terrace                 = true,
                Spit                    = true,
                Lamps                   = true,
                Nets                    = true,
                Blinds                  = true,
                Curtains                = true,
                Tank                    = true,
                CapacityTank            = decimal.Parse("1"),
                WaterPressure           = true,
                canchasDeportivas       = true,
                lido                    = true,
                CaracteristicasPiscina  = "1",
                AirConditioner          = true,
                CommonArea              = true,
                HouseClub               = true,
                Description             = "1",
                Id_Owner                = 1,
                Id_Currency             = 1,
                PrecioM2                = 1,
                Entrega                 = "Seguro que si",
                AnticipoVenta           = decimal.Parse("1"),
                TipoVendedor            = decimal.Parse("1"),
                OtroTipoVendedor        = decimal.Parse("1"),
                EscrituraLiberada       = true,
                NumEscritura            = "sadssf",
                CreditoVigente          = true,
                DeudaCredito            = decimal.Parse("1"),
                LibreGravamen           = true,
                ServiciosAlCorriente    = true,
                VentaUltimos3anhos      = true,
                ConoceLeyAntilavado     = true,
                OtroEstatusLegal        = "1"
            };

            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                if (estate != null)
                {
                    connection.Open();

                    string query = "INSERT INTO Properties (Id_City,Id_Locality,OperationType,Id_Sector,Id_Product,Id_SalesRep,AmountRent,AmountBuy,Stat, " +
                                   "Final_Prc, Id_SalesFinal, Street, Id_Colony, PostCode, Num, Supp1, Id_Ground, " +
                                   "Conditions, Maintenance, MonthDeposit, FiscalReceipt, Furnished, Bailor, LegalPolicy, Other, isPrivate, " +
                                   "Provisional, CurrentMaintenance, LightService, WaterService, GasService, SewerSystem, TelService, CableService, Area, " +
                                   "Construction, Antique, Front, BackGround, levels, Garden, OtherCharac, Kitchen, KitchenStat, " +
                                   "Housing, FretsSoap, TvRoom, Study, Bar, Rooms, NumRooms, Closet, NumCloset, " +
                                   "DressingRoom, NumDressingRom, Bath, NumBath, MiddleBath, NumMiddleBath, ServiceYard, MultipleSalon, ServiceCorridor, " +
                                   "NumServiceCorridor, Cellar, NumCellar, ServiceRoom, NumServiceRoom, Parking, NumParking, ParkingVisit, NumParkingVisit, " +
                                   "Smokestack, Jacuzzi, Vat, Alarm, ElectricFence, Policy, SpotsFields, IrrigationSystem, Garden1, " +
                                   "Terrace, Spit, Lamps, Nets, Blinds, Curtains, Tank, CapacityTank, WaterPressure, " +
                                   "lido, AirConditioner, CommonArea, HouseClub, Description, Id_Owner, FechaCaptura, Zone_Id, Id_Currency, " +
                                   "PrecioM2, Entrega, AnticipoVenta, TipoVendedor, OtroTipoVendedor, Id_ProdCat, EscrituraLiberada, NumEscritura, CreditoVigente, " +
                                   "DeudaCredito, LibreGravamen, ServiciosAlCorriente, VentaUltimos3anhos, ConoceLeyAntilavado, OtroEstatusLegal, CaracteristicasPiscina, comision, numeroInterior, " +
                                   "servicios, fechaDisponible, canchasDeportivas,CurrentPredial) " +
                                   "VALUES " +
                                   "(@Id_City,@Id_Locality,@OperationType,@Id_Sector,@Id_Product,@Id_SalesRep,@AmountRent,@AmountBuy,@Stat, " +
                                   "@Final_Prc, @Id_SalesFinal, @Street, @Id_Colony, @PostCode, @Num, @Supp1, @Id_Ground, " +
                                   "@Conditions, @Maintenance, @MonthDeposit, @FiscalReceipt, @Furnished, @Bailor, @LegalPolicy, @Other, @isPrivate, " +
                                   "@Provisional, @CurrentMaintenance, @LightService, @WaterService, @GasService, @SewerSystem, @TelService, @CableService, @Area, " +
                                   "@Construction, @Antique, @Front, @BackGround, @levels, @Garden, @OtherCharac, @Kitchen, @KitchenStat, " +
                                   "@Housing, @FretsSoap, @TvRoom, @Study, @Bar, @Rooms, @NumRooms, @Closet, @NumCloset, " +
                                   "@DressingRoom, @NumDressingRom, @Bath, @NumBath, @MiddleBath, @NumMiddleBath, @ServiceYard, @MultipleSalon, @ServiceCorridor, " +
                                   "@NumServiceCorridor, @Cellar, @NumCellar, @ServiceRoom, @NumServiceRoom, @Parking, @NumParking, @ParkingVisit, @NumParkingVisit, " +
                                   "@Smokestack, @Jacuzzi, @Vat, @Alarm, @ElectricFence, @Policy, @SpotsFields, @IrrigationSystem, @Garden1, " +
                                   "@Terrace, @Spit, @Lamps, @Nets, @Blinds, @Curtains, @Tank, @CapacityTank, @WaterPressure, " +
                                   "@lido, @AirConditioner, @CommonArea, @HouseClub, @Description, @Id_Owner, @FechaCaptura, @Zone_Id, @Id_Currency, " +
                                   "@PrecioM2, @Entrega, @AnticipoVenta, @TipoVendedor, @OtroTipoVendedor, @Id_ProdCat, @EscrituraLiberada, @NumEscritura, @CreditoVigente, " +
                                   "@DeudaCredito, @LibreGravamen, @ServiciosAlCorriente, @VentaUltimos3anhos, @ConoceLeyAntilavado, @OtroEstatusLegal, @CaracteristicasPiscina, @comision, @numeroInterior, " +
                                   "@servicios, @fechaDisponible, @canchasDeportivas, @CurrentPredial);" +
                                   "SELECT @@IDENTITY";



                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;

                    //command.Parameters.Add("@PropertyKey",            SqlDbType.VarChar, 50).Value = estate.PropertyKey;
                    command.Parameters.Add("@Id_City",                SqlDbType.Int).Value = estate.IdCity;
                    command.Parameters.Add("@Id_Locality",            SqlDbType.Int).Value = estate.IdLocality;
                    command.Parameters.Add("@OperationType",          SqlDbType.VarChar, 30).Value = estate.OperationType;
                    command.Parameters.Add("@Id_Sector",              SqlDbType.TinyInt).Value = int.Parse(estate.IdSector.ToString());
                    command.Parameters.Add("@Id_Product",             SqlDbType.Int).Value = estate.IdProduct;
                    command.Parameters.Add("@Id_SalesRep",            SqlDbType.Int).Value = 4;
                    command.Parameters.Add("@AmountRent",             SqlDbType.Decimal, 10).Value = estate.AmountRent;
                    command.Parameters.Add("@AmountBuy",              SqlDbType.Decimal, 10).Value = estate.AmountBuy;
                    command.Parameters.Add("@Stat",                   SqlDbType.VarChar, 30).Value = estate.Stat;
                    command.Parameters.Add("@Final_Prc",              SqlDbType.Decimal, 10).Value = estate.FinalPrc;
                    command.Parameters.Add("@Id_SalesFinal",          SqlDbType.Int).Value = estate.IdSalesFinal;
                    command.Parameters.Add("@Street",                 SqlDbType.NVarChar, 80).Value = estate.Street;
                    command.Parameters.Add("@Id_Colony",              SqlDbType.Int).Value = estate.IdColony;
                    command.Parameters.Add("@PostCode",               SqlDbType.NVarChar, 15).Value = estate.PostCode;
                    command.Parameters.Add("@Num",                    SqlDbType.NVarChar, 15).Value = estate.Number;
                    command.Parameters.Add("@Supp1",                  SqlDbType.NVarChar, 15).Value = estate.Surface; /////////??????
                    //command.Parameters.Add("@Id_Region",              SqlDbType.TinyInt).Value = int.Parse(estate.IdRegion.ToString());
                    command.Parameters.Add("@Id_Ground",              SqlDbType.TinyInt).Value = int.Parse(estate.IdGround.ToString());
                    command.Parameters.Add("@Conditions",             SqlDbType.VarChar, 50).Value = estate.Conditions;
                    command.Parameters.Add("@Maintenance",            SqlDbType.Bit).Value = Convert.ToInt32(estate.Maintenance);
                    command.Parameters.Add("@MonthDeposit",           SqlDbType.TinyInt).Value = int.Parse(estate.MonthDeposit.ToString());
                    command.Parameters.Add("@FiscalReceipt",          SqlDbType.Bit).Value = Convert.ToInt32(estate.FiscalReceipt);
                    command.Parameters.Add("@Furnished",              SqlDbType.Bit).Value = Convert.ToInt32(estate.Furnished);
                    command.Parameters.Add("@Bailor",                 SqlDbType.Bit).Value = Convert.ToInt32(estate.Bailor);
                    command.Parameters.Add("@LegalPolicy",            SqlDbType.Bit).Value = Convert.ToInt32(estate.LegalPolicy);
                    command.Parameters.Add("@Other",                  SqlDbType.NVarChar, 255).Value = estate.Other;
                    command.Parameters.Add("@isPrivate",              SqlDbType.Bit).Value = Convert.ToInt32(estate.IsPrivate);
                    command.Parameters.Add("@Provisional",            SqlDbType.Bit).Value = Convert.ToInt32(estate.Provisional);
                    command.Parameters.Add("@CurrentMaintenance",     SqlDbType.Bit).Value = Convert.ToInt32(estate.CurrentMaintenance);
                    command.Parameters.Add("@LightService",           SqlDbType.Bit).Value = Convert.ToInt32(estate.LightService);
                    command.Parameters.Add("@WaterService",           SqlDbType.Bit).Value = Convert.ToInt32(estate.WaterService);
                    command.Parameters.Add("@GasService",             SqlDbType.Bit).Value = Convert.ToInt32(estate.GasService);
                    command.Parameters.Add("@SewerSystem",            SqlDbType.Bit).Value = Convert.ToInt32(estate.SewerSystem);
                    command.Parameters.Add("@TelService",             SqlDbType.Bit).Value = Convert.ToInt32(estate.TelService);
                    command.Parameters.Add("@CableService",           SqlDbType.Bit).Value = Convert.ToInt32(estate.CableService);
                    command.Parameters.Add("@Area",                   SqlDbType.Decimal, 10).Value = estate.Area;
                    command.Parameters.Add("@Construction",           SqlDbType.Decimal, 10).Value = estate.Construction;
                    command.Parameters.Add("@Antique",                SqlDbType.Int).Value = estate.Antique;
                    command.Parameters.Add("@Front",                  SqlDbType.Decimal, 10).Value = estate.Front;
                    command.Parameters.Add("@BackGround",             SqlDbType.Decimal, 10).Value = estate.BackGround;
                    command.Parameters.Add("@levels",                 SqlDbType.TinyInt).Value = int.Parse(estate.Levels.ToString());
                    command.Parameters.Add("@OtherCharac",            SqlDbType.NVarChar, 255).Value = estate.OtherCharac;
                    command.Parameters.Add("@Garden",                 SqlDbType.Decimal, 10).Value = estate.Garden;
                    command.Parameters.Add("@Kitchen",                SqlDbType.Bit).Value = Convert.ToInt32(estate.Kitchen);
                    command.Parameters.Add("@KitchenStat",            SqlDbType.VarChar, 50).Value = estate.KitchenStat;
                    command.Parameters.Add("@Housing",                SqlDbType.NVarChar, 50).Value = estate.Housing;
                    command.Parameters.Add("@FretsSoap",              SqlDbType.Bit).Value = Convert.ToInt32(estate.FretsSoap);
                    command.Parameters.Add("@TvRoom",                 SqlDbType.Bit).Value = Convert.ToInt32(estate.TvRoom);
                    command.Parameters.Add("@Study",                  SqlDbType.Bit).Value = Convert.ToInt32(estate.Study);
                    command.Parameters.Add("@Bar",                    SqlDbType.Bit).Value = Convert.ToInt32(estate.Bar);
                    command.Parameters.Add("@Rooms",                  SqlDbType.Bit).Value = Convert.ToInt32(estate.Rooms);
                    command.Parameters.Add("@NumRooms",               SqlDbType.TinyInt).Value = int.Parse(estate.NumRooms.ToString());
                    command.Parameters.Add("@Closet",                 SqlDbType.Bit).Value = Convert.ToInt32(estate.Closet);
                    command.Parameters.Add("@NumCloset",              SqlDbType.TinyInt).Value = int.Parse(estate.NumCloset.ToString());
                    command.Parameters.Add("@DressingRoom",           SqlDbType.Bit).Value = Convert.ToInt32(estate.DressingRoom);
                    command.Parameters.Add("@NumDressingRom",         SqlDbType.TinyInt).Value = int.Parse(estate.NumDressingRom.ToString());
                    command.Parameters.Add("@Bath",                   SqlDbType.Bit).Value = Convert.ToInt32(estate.Bath);
                    command.Parameters.Add("@NumBath",                SqlDbType.TinyInt).Value = int.Parse(estate.NumBath.ToString());
                    command.Parameters.Add("@MiddleBath",             SqlDbType.Bit).Value = Convert.ToInt32(estate.MiddleBath);
                    command.Parameters.Add("@NumMiddleBath",          SqlDbType.TinyInt).Value = int.Parse(estate.NumMiddleBath.ToString());
                    command.Parameters.Add("@ServiceYard",            SqlDbType.Bit).Value = Convert.ToInt32(estate.ServiceYard);
                    command.Parameters.Add("@MultipleSalon",          SqlDbType.Bit).Value = Convert.ToInt32(estate.MultipleSalon);
                    command.Parameters.Add("@ServiceCorridor",        SqlDbType.Bit).Value = Convert.ToInt32(estate.ServiceCorridor);
                    command.Parameters.Add("@NumServiceCorridor",     SqlDbType.TinyInt).Value = int.Parse(estate.NumServiceCorridor.ToString());
                    command.Parameters.Add("@Cellar",                 SqlDbType.Int).Value = estate.Cellar;
                    command.Parameters.Add("@NumCellar",              SqlDbType.TinyInt).Value = int.Parse(estate.NumCellar.ToString());
                    command.Parameters.Add("@ServiceRoom",            SqlDbType.Bit).Value = Convert.ToInt32(estate.ServiceRoom);
                    command.Parameters.Add("@NumServiceRoom",         SqlDbType.TinyInt).Value = int.Parse(estate.NumServiceRoom.ToString());
                    command.Parameters.Add("@Parking",                SqlDbType.Bit).Value = Convert.ToInt32(estate.Parking);
                    command.Parameters.Add("@NumParking",             SqlDbType.TinyInt).Value = int.Parse(estate.NumParking.ToString());
                    command.Parameters.Add("@ParkingVisit",           SqlDbType.Bit).Value = Convert.ToInt32(estate.ParkingVisit);
                    command.Parameters.Add("@NumParkingVisit",        SqlDbType.TinyInt).Value = int.Parse(estate.NumParkingVisit.ToString());
                    command.Parameters.Add("@Smokestack",             SqlDbType.Bit).Value = Convert.ToInt32(estate.Smokestack);
                    command.Parameters.Add("@Jacuzzi",                SqlDbType.Bit).Value = Convert.ToInt32(estate.Jacuzzi);
                    command.Parameters.Add("@Vat",                    SqlDbType.Bit).Value = Convert.ToInt32(estate.Vat);
                    command.Parameters.Add("@Alarm",                  SqlDbType.Bit).Value = Convert.ToInt32(estate.Alarm);
                    command.Parameters.Add("@ElectricFence",          SqlDbType.Bit).Value = Convert.ToInt32(estate.ElectricFence);
                    command.Parameters.Add("@Policy",                 SqlDbType.Bit).Value = Convert.ToInt32(estate.Policy);
                    command.Parameters.Add("@SpotsFields",            SqlDbType.Bit).Value = Convert.ToInt32(estate.SpotsFields);
                    command.Parameters.Add("@IrrigationSystem",       SqlDbType.Bit).Value = Convert.ToInt32(estate.IrrigationSystem);
                    command.Parameters.Add("@Garden1",                SqlDbType.Bit).Value = Convert.ToInt32(estate.Garden1);
                    command.Parameters.Add("@Terrace",                SqlDbType.Bit).Value = Convert.ToInt32(estate.Terrace);
                    command.Parameters.Add("@Spit",                   SqlDbType.Bit).Value = Convert.ToInt32(estate.Spit);
                    command.Parameters.Add("@Lamps",                  SqlDbType.Bit).Value = Convert.ToInt32(estate.Lamps);
                    command.Parameters.Add("@Nets",                   SqlDbType.Bit).Value = Convert.ToInt32(estate.Nets);
                    command.Parameters.Add("@Blinds",                 SqlDbType.Bit).Value = Convert.ToInt32(estate.Blinds);
                    command.Parameters.Add("@Curtains",               SqlDbType.Bit).Value = Convert.ToInt32(estate.Curtains);
                    command.Parameters.Add("@Tank",                   SqlDbType.Bit).Value = Convert.ToInt32(estate.Tank);
                    command.Parameters.Add("@CapacityTank",           SqlDbType.Decimal, 10).Value = estate.CapacityTank;
                    command.Parameters.Add("@WaterPressure",          SqlDbType.Bit).Value = Convert.ToInt32(estate.WaterPressure);
                    command.Parameters.Add("@lido",                   SqlDbType.Bit).Value = Convert.ToInt32(estate.lido);
                    command.Parameters.Add("@AirConditioner",         SqlDbType.Bit).Value = Convert.ToInt32(estate.AirConditioner);
                    command.Parameters.Add("@CommonArea",             SqlDbType.Bit).Value = Convert.ToInt32(estate.CommonArea);
                    command.Parameters.Add("@HouseClub",              SqlDbType.Bit).Value = Convert.ToInt32(estate.HouseClub);
                    command.Parameters.Add("@Description",            SqlDbType.VarChar, 4096).Value = estate.Description;
                    command.Parameters.Add("@Id_Owner",               SqlDbType.Int).Value = 2;
                    command.Parameters.Add("@FechaCaptura",           SqlDbType.DateTime).Value = estate.FechaCaptura;
                    command.Parameters.Add("@Zone_Id",                SqlDbType.Int).Value = 4;
                    command.Parameters.Add("@Id_Currency",            SqlDbType.Int).Value = estate.Id_Currency;
                    command.Parameters.Add("@PrecioM2",               SqlDbType.Decimal, 10).Value = estate.PrecioM2;
                    command.Parameters.Add("@Entrega",                SqlDbType.VarChar, 250).Value = estate.Entrega;
                    command.Parameters.Add("@AnticipoVenta",          SqlDbType.Decimal, 10).Value = estate.AnticipoVenta;
                    command.Parameters.Add("@TipoVendedor",           SqlDbType.VarChar, 80).Value = estate.TipoVendedor;
                    command.Parameters.Add("@OtroTipoVendedor",       SqlDbType.VarChar, 250).Value = estate.OtroTipoVendedor;
                    command.Parameters.Add("@Id_ProdCat",             SqlDbType.Int).Value = estate.IdProdCat;
                    command.Parameters.Add("@EscrituraLiberada",      SqlDbType.Bit).Value = Convert.ToInt32(estate.EscrituraLiberada);
                    command.Parameters.Add("@NumEscritura",           SqlDbType.NVarChar, 30).Value = estate.NumEscritura;
                    command.Parameters.Add("@CreditoVigente",         SqlDbType.Bit).Value = Convert.ToInt32(estate.CreditoVigente);
                    command.Parameters.Add("@DeudaCredito",           SqlDbType.Decimal, 10).Value = estate.DeudaCredito;
                    command.Parameters.Add("@LibreGravamen",          SqlDbType.Bit).Value = Convert.ToInt32(estate.LibreGravamen);
                    command.Parameters.Add("@ServiciosAlCorriente",   SqlDbType.Bit).Value = Convert.ToInt32(estate.ServiciosAlCorriente);
                    command.Parameters.Add("@VentaUltimos3anhos",     SqlDbType.Bit).Value = Convert.ToInt32(estate.VentaUltimos3anhos);
                    command.Parameters.Add("@ConoceLeyAntilavado",    SqlDbType.Bit).Value = Convert.ToInt32(estate.ConoceLeyAntilavado);
                    command.Parameters.Add("@OtroEstatusLegal",       SqlDbType.NVarChar, 1024).Value = estate.OtroEstatusLegal;
                    command.Parameters.Add("@CaracteristicasPiscina", SqlDbType.VarChar).Value = estate.CaracteristicasPiscina;
                    command.Parameters.Add("@comision",               SqlDbType.Decimal, 5).Value = estate.Commission;
                    command.Parameters.Add("@numeroInterior",         SqlDbType.VarChar, 15).Value = estate.InteriorNumber;
                    command.Parameters.Add("@servicios",              SqlDbType.Bit).Value = Convert.ToInt32(estate.Services);
                    command.Parameters.Add("@fechaDisponible",        SqlDbType.Date).Value = estate.FechaCaptura.Date; //////////////////?????????????
                    command.Parameters.Add("@canchasDeportivas",      SqlDbType.Bit).Value = Convert.ToInt32(estate.canchasDeportivas);
                    command.Parameters.Add("@CurrentPredial",         SqlDbType.Bit).Value = Convert.ToInt32(estate.CurrentPredial);
                    //command.Parameters.Add("@dias",             SqlDbType.Int).Value = 120;

                    try
                    {
                        //estate = new Estate();
                        estate.IdProperty = int.Parse(command.ExecuteScalar().ToString());
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    
                }
            }
            return null;
        }
    }
}
