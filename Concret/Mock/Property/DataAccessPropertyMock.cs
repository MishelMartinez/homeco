using System;
using System.Collections.Generic;
using InmobiliariasHomeCo.Abstract.Properties;
using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Currencies;
using InmobiliariasHomeCo.Entities.Locations;
using InmobiliariasHomeCo.Entities.Properties;
using InmobiliariasHomeCo.Entities.Properties.Locations;

namespace InmobiliariasHomeCo.Concret.Mock.Properties
{
    public class DataAccessPropertyMock : IDataAccessProperty
    {
        public string AdShCity(int Id_State)
        {
            throw new NotImplementedException();
        }

        public string AdShColony(int Id_City)
        {
            throw new NotImplementedException();
        }

        public string AdShPropertySubType(int IdTypeOperation)
        {
            throw new NotImplementedException();
        }

        public string AdShPropertyType(int IdProperty)
        {
            throw new NotImplementedException();
        }

        public string AdShState(int IdProperty)
        {
            throw new NotImplementedException();
        }

        public string AdShTypeOperation(int IdProperty)
        {
            throw new NotImplementedException();
        }

   
        public string AdShZone(int Id_Colony, int Id_City)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsGroundType(int Id_Ground)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsPropertySubType(int id_PropertySubType)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsPropertyType(int id_PropertyType)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsSector(int id_Sector)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsSource(int Id_Source)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsTypeOperation(int id_PropertyType)
        {
            throw new NotImplementedException();
        }

        public string DeleteBaseCatalogsZone(int zone_id)
        {
            throw new NotImplementedException();
        }

        public string DeleteConfigurationCity(int Id_City)
        {
            throw new NotImplementedException();
        }

        public string DeleteConfigurationColony(int Id_Colony)
        {
            throw new NotImplementedException();
        }

        public string DeleteConfigurationState(int Id_State)
        {
            throw new NotImplementedException();
        }

        public string DeleteOwner(int Id_Owner)
        {
            throw new NotImplementedException();
        }

        public string DeleteProperty(int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string DeleteRol(int Id_User)
        {
            throw new NotImplementedException();
        }

        public string DeleteRolUser(int Id_User)
        {
            throw new NotImplementedException();
        }

        public string DeleteSalesRep(int Id_SalesRep)
        {
            throw new NotImplementedException();
        }

        public string DeleteUser(int Id_User)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForRentSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType)
        {
            throw new NotImplementedException();
        }

        public string GetAdShAdvancedSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished)
        {
            throw new NotImplementedException();
        }

        public string GetAdShSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin)
        {
            throw new NotImplementedException();
        }

        public string GetAdShSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType)
        {
            throw new NotImplementedException();
        }

        public string GetAdShSearchPropertyForRentSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType)
        {
            throw new NotImplementedException();
        }

        public string GetAdShSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin)
        {
            throw new NotImplementedException();
        }

        public string GetAdShSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType)
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsGroundType()
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsPropertySubType(int id_PropertyType)
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsPropertyType()
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsSector()
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsSource()
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsTypeOperation()
        {
            throw new NotImplementedException();
        }

        public string GetBaseCatalogsZone(int Id_City)
        {
            throw new NotImplementedException();
        }

        public string GetConfigurationCity(int Id_State)
        {
            throw new NotImplementedException();
        }

        public string GetConfigurationColony(int Id_Colony)
        {
            throw new NotImplementedException();
        }

        public string GetConfigurationCountry(int Key)
        {
            throw new NotImplementedException();
        }

        public string GetConfigurationPostCode(int Id_City)
        {
            throw new NotImplementedException();
        }

        public string GetConfigurationState(int Id_State)
        {
            throw new NotImplementedException();
        }

        public string GetConfigurationStates(int Key)
        {
            throw new NotImplementedException();
        }

        public string GetDataSheetSpace(int IdProperty)
        {
            throw new NotImplementedException();
        }

        public Property[] GetProperties()
        {
            List<Property> properties = new List<Property>();
            properties.Add(
                new Property()
                {
                    IdProperty = 1,
                    PropertyKey = "HOME5",
                    Characteristics = new PropertyCharacteristics()
                    {
                        Address = new Address()
                        {
                            Id = 1,
                            City = new City()
                            {
                                Name = "",
                                State = new State()
                                {
                                    Name = "",
                                    Country = new Country()
                                    {
                                        Name = ""
                                    }
                                }
                            },
                            Country = new Country()
                            {
                                Name = ""
                            },
                            InteriorNumber = "",
                            OutdoorNumber = "",
                            PostCode = ""
                        },
                        Services = new List<Service>(){
                        new Service()
                        {
                            Id = 1,
                            Description = "Gas"
                        },
                        new Service()
                        {
                            Id = 2,
                            Description = "Agua"
                        },
                        new Service()
                        {
                            Id = 3,
                            Description = "Luz"
                        }
                    }.ToArray(),
                        Areas = new List<Area>()
                    {
                        new Area()
                        {
                            Id    = 1,
                            Name  = "Area1",
                            Count = 2,
                            Measure = 300
                        },
                        new Area()
                        {
                            Id    = 2,
                            Name  = "Area1",
                            Count = 1,
                            Measure = 100
                        }
                    }.ToArray(),

                        Description = "",
                        Construction = 400,
                        Area = 400,
                        Levels = 3,
                        AntiguatyYears = 10

                    },
                    Currency = new Currency()
                    {
                        Id = 1,
                        Description = ""
                    },
                    PropertyImages = new PropertyImage[]
                    {
                        new PropertyImage() {
                            Principal = true,
                            Url = "https://images.homify.com/c_fill,f_auto,q_auto:eco,w_980/v1447816507/p/photo/image/1123069/IMG_2279.jpg"
                        }
                    }
                }
            );

            properties.Add(
                new Property()
                {
                    IdProperty = 1,
                    PropertyKey = "HOME6",
                    Characteristics = new PropertyCharacteristics()
                    {
                        Address = new Address()
                        {
                            Id = 1,
                            City = new City()
                            {
                                Name = "",
                                State = new State()
                                {
                                    Name = "",
                                    Country = new Country()
                                    {
                                        Name = ""
                                    }
                                }
                            },
                            Country = new Country()
                            {
                                Name = ""
                            },
                            InteriorNumber = "",
                            OutdoorNumber = "",
                            PostCode = ""
                        },
                        Services = new List<Service>(){
                        new Service()
                        {
                            Id = 1,
                            Description = "Gas"
                        },
                        new Service()
                        {
                            Id = 2,
                            Description = "Agua"
                        },
                        new Service()
                        {
                            Id = 3,
                            Description = "Luz"
                        }
                    }.ToArray(),
                        Areas = new List<Area>()
                    {
                        new Area()
                        {
                            Id    = 1,
                            Name  = "Area1",
                            Count = 2,
                            Measure = 300
                        },
                        new Area()
                        {
                            Id    = 2,
                            Name  = "Area1",
                            Count = 1,
                            Measure = 100
                        }
                    }.ToArray(),

                        Description = "",
                        Construction = 400,
                        Area = 400,
                        Levels = 3,
                        AntiguatyYears = 10

                    },
                    Currency = new Currency()
                    {
                        Id = 1,
                        Description = ""
                    },


                    PropertyImages = new PropertyImage[]
                    {
                        new PropertyImage() {
                        Principal = true,
                        Url = "https://images.homify.com/c_fill,f_auto,q_auto:eco,w_980/v1467349653/p/photo/image/1566919/projekt-domu-dom-z-widokiem-05.jpg"
                        }
                    }



                    



                }
            );

            return properties.ToArray();
        }



        public Property GetPropertiesTechnicalSheet(int PropertyKey)
        {
            return new Property()
            {
                PropertyKey = "MX18-EC3225",
                PropertyImages = new PropertyImage[]
                {   
                    new PropertyImage() {
                        Url = "http://grupobms.com/homeco/assets/images/property/casa1.1.jpg",
                        Description = "CASA DE 2 PISOS"
                    },
                    new PropertyImage() {
                        Url = "http://grupobms.com/homeco/assets/images/property/casa1.3.jpg",
                        Description = "HABITACIÓN PRINCIPAL"
                    },
                    new PropertyImage() {
                        Url = "http://grupobms.com/homeco/assets/images/property/casa1.2.jpg",
                        Description = "BAÑOS CON ACABADOS DE LUJO"
                    },
                    new PropertyImage() {
                        Url = "http://grupobms.com/homeco/assets/images/property/casa1.jpg",
                        Description = "si salio"
                    }
                }   
            };
        }



        public PropertyTest[] GetPropertiesTest()
        {
            return new List<PropertyTest>()
            {
                new PropertyTest()
            {
                Location = "juquilla queretaro",
                zona = "Zonas Villas",
                firstname = "Azul Celeste",
                numberbathrooms = 1,
                numberrooms = 2,
                img = "assets/images/housecatalog/venta3.jpg",
                price = "$3,000",
                partnernumber = "DV4386",
                size = "147 sq ft",
                state = "Renta",
                estado = "queretaro",
                rentaventa = "Departamento en Venta"
            },
                new PropertyTest()
            {
                Location = "juquilla queretaro",
                zona = "Zonas Villas",
                firstname = "Azul Celeste",
                numberbathrooms = 1,
                numberrooms = 2,
                img = "assets/images/housecatalog/venta1.jpg",
                price = "690,000 MXN",
                partnernumber = "DV4386",
                size = "963 sq ft",
                state = "Renta",
                estado = "queretaro",
                rentaventa = "Departamento en Venta"
            }
            }.ToArray();
        }

        public string GetPropertyCurrency()
        {
            throw new NotImplementedException();
        }

        public string GetPropertyGroundType()
        {
            throw new NotImplementedException();
        }

        public string GetPropertyImages(int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string GetPropertyKey()
        {
            throw new NotImplementedException();
        }

        public string GetPropertySubTypee(int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string GetPropertyZone(int Id_Colony)
        {
            throw new NotImplementedException();
        }

        public string GetRoles(int Id_User)
        {
            throw new NotImplementedException();
        }

        public string GetRolesForUser(int Id_User)
        {
            throw new NotImplementedException();
        }

        public string GetSalesRep()
        {
            throw new NotImplementedException();
        }

        public string GetSalesRepBank()
        {
            throw new NotImplementedException();
        }

        public string GetShowProperty(int IdProperty)
        {
            throw new NotImplementedException();
        }

        public string GetUpdateOwner(int Id_Owner)
        {
            throw new NotImplementedException();
        }

        public string GetUpdatePropertyForRent(int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string GetUpdatePropertyForRentSale(int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string GetUpdatePropertyForSale(int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string GetUpdateRol(int Id_Rol)
        {
            throw new NotImplementedException();
        }

        public string GetUpdateSalesRep(int Id_SalesRep)
        {
            throw new NotImplementedException();
        }

        public string GetUpdateUser(int Id_User)
        {
            throw new NotImplementedException();
        }

        public string GetUsers(int Key)
        {
            throw new NotImplementedException();
        }

        public string GetUsersRol(int Key)
        {
            throw new NotImplementedException();
        }

        public string HCGetOwner()
        {
            throw new NotImplementedException();
        }

        public string HCGetOwnerSalesRep()
        {
            throw new NotImplementedException();
        }

        public string HCGetProperty(int Id_PropertyType, int Id_TypeOperation, int Id_State, int Id_City)
        {
            throw new NotImplementedException();
        }


        /*
         * 
         * 
         */


        public Property InsertProperty(Property property)
        {
            return null;
        }

        public string SetBaseCatalogsGroundType(string GroudType)
        {
            throw new NotImplementedException();
        }

        public string SetBaseCatalogsPropertySubType(string PropertySubType, string Descripcion, int Id_PropertyType)
        {
            throw new NotImplementedException();
        }

        public string SetBaseCatalogsPropertyType(string Descripcion)
        {
            throw new NotImplementedException();
        }

        public string SetBaseCatalogsSector(string Sector)
        {
            throw new NotImplementedException();
        }

        public string SetBaseCatalogsSource(string Source)
        {
            throw new NotImplementedException();
        }

        public string SetBaseCatalogsTypeOperation(string Operation)
        {
            throw new NotImplementedException();
        }

        public string SetBaseCatalogsZone(string zone_name, int Id_City, int Id_Colony)
        {
            throw new NotImplementedException();
        }

        public string SetConfigurationCity(int Id_State, string CityName)
        {
            throw new NotImplementedException();
        }

        public string SetConfigurationColony(int Id_City, string Colony, string PostCode)
        {
            throw new NotImplementedException();
        }

        public string SetConfigurationState(int Id_Country, string State)
        {
            throw new NotImplementedException();
        }

        public string SetContact(string Nombre, string Email, string Asunto, string Mensaje)
        {
            throw new NotImplementedException();
        }

        public string SetOwner(string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_SalesRep)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRentSale(int Id_City,string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRentSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRentSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRentSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForRentSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string año, string mes, string dia, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForSale(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string SetPropertyForSaleRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string SetRol(string name, string Description)
        {
            throw new NotImplementedException();
        }

        public string SetRolUser(int Id_User, int Id_Role)
        {
            throw new NotImplementedException();
        }

        public string SetSalesRep(string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, string InitialDate, string Title, string URLPhoto, string TaxRef, int Id_Bank, string BankReference)
        {
            throw new NotImplementedException();
        }

        public string SetUser(string NameUser, string FullName, string IsEnabled, string Email, string Passsword)
        {
            throw new NotImplementedException();
        }

        public string SetUsers(string UserName, int Id_Rol, string FullName, string CreateDate, bool IsEnabled, bool IsAdminBms, string Email)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsGroundType(int Id_Ground, string GroudType)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsPropertySubType(int id_PropertySubType, string PropertySubType, string Descripcion, int Id_PropertyType)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsPropertyType(int id_PropertyType, string Descripcion)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsSector(int id_Sector, string Sector)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsSource(int Id_Source, string Source)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsTypeOperation(int Id_TypeOperation, string Operation)
        {
            throw new NotImplementedException();
        }

        public string UpdateBaseCatalogsZone(int zone_id, string zone_name, int Id_City)
        {
            throw new NotImplementedException();
        }

        public string UpdateConfigurationCity(int Id_City, string CityName)
        {
            throw new NotImplementedException();
        }

        public string UpdateConfigurationColony(int Id_Colony, string Colony)
        {
            throw new NotImplementedException();
        }

        public string UpdateConfigurationState(int Id_State, string State)
        {
            throw new NotImplementedException();
        }

        public string UpdateOwner(int Id_Person, string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_Owner, int Id_SalesRep)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRent(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRent(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRent(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRent(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRent(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRent(int Id_Property, int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRentSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRentSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRentSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRentSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForRentSale(int Id_Property, int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForSale(int Id_Property, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyForSale(int Id_Property, int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyImages(string MimeType, string Principal, string Description, string Url, int Id_Property)
        {
            throw new NotImplementedException();
        }

        public string UpdatePropertyImages(string MimeType, string Principal, string Description, string Url, int Id_Property, string MimeType1, string Principal1, string Description1, string Url1, string MimeType2, string Principal2, string Description2, string Url2, string MimeType3, string Principal3, string Description3, string Url3)
        {
            throw new NotImplementedException();
        }

        public string UpdateRol(int Id_Rol, string name, string Description)
        {
            throw new NotImplementedException();
        }

        public string UpdateSalesRep(int Id_SalesRep, string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_Person, string InitialDate, string Title, string URLPhoto, string TaxRef, int Id_Bank, string BankReference)
        {
            throw new NotImplementedException();
        }

        public string UpdateUser(int Id_User, string NameUser, string FullName, string IsEnabled, string Email, string Passsword)
        {
            throw new NotImplementedException();
        }

        public string ValidatePropertySubTypeZone(int Id_PropertyType)
        {
            throw new NotImplementedException();
        }

        public string ValidatePropertyZone(int Id_PropertyType)
        {
            throw new NotImplementedException();
        }

        string IDataAccessProperty.GetDataSheetAdrees(int IdProperty)
        {
            throw new NotImplementedException();
        }

        string IDataAccessProperty.GetDataSheetImages(int IdProperty)
        {
            throw new NotImplementedException();
        }

        Property[] IDataAccessProperty.GetProperties()
        {
            throw new NotImplementedException();
        }

        string IDataAccessProperty.GetPropertiesTechnicalSheet(int IdProperty)
        {
            throw new NotImplementedException();
        }

        PropertyTest[] IDataAccessProperty.GetPropertiesTest()
        {
            throw new NotImplementedException();
        }

        Property IDataAccessProperty.InsertProperty(Property property)
        {
            throw new NotImplementedException();
        }
    }
}
