using System;
using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Properties;

namespace InmobiliariasHomeCo.Abstract.Properties
{
    public interface IDataAccessProperty
    {
        Property InsertProperty(Property property);
        Property[] GetProperties();

        PropertyTest[] GetPropertiesTest();

        string GetPropertiesTechnicalSheet(int IdProperty);
        string GetDataSheetImages(int IdProperty);
        string GetDataSheetAdrees(int IdProperty);
        string GetDataSheetSpace(int IdProperty);
        string GetShowProperty(int IdProperty);
        string AdShTypeOperation(int IdProperty);
        string AdShPropertyType(int IdProperty);
        string AdShState(int IdProperty);
        string AdShPropertySubType(int IdTypeOperation);
        string AdShCity(int Id_State);
        string AdShColony(int Id_City);
        string AdShZone(int Id_Colony, int Id_City);
        string GetAdShSearchPropertyForRentSale (int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType);
        string GetAdShSearchPropertyForRent     (int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType);
        string GetAdShSearchPropertyForSale     (int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType);
        string GetAdShAdvancedSearchPropertyForRentSale     (int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished);
        string GetAdShAdvancedSearchPropertyForSale         (int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished);
        string GetAdShAdvancedSearchPropertyForRent         (int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished);
        string GetUsers(int Key);
        string GetUsersRol(int Key);
        string SetUsers(string UserName, int Id_Rol, string FullName, string CreateDate, Boolean IsEnabled, Boolean IsAdminBms, string Email);
        string GetConfigurationCountry(int Key);
        string GetConfigurationStates(int Id_Country);
        string GetConfigurationState(int Id_State);
        string SetConfigurationState(int Id_Country, string State);
        string SetContact(string Nombre, string Email, string Asunto, string Mensaje);
        string UpdateConfigurationState(int Id_State, string State);
        string DeleteConfigurationState(int Id_State);
        string SetConfigurationCity(int Id_State, string CityName);
        string UpdateConfigurationCity(int Id_City, string CityName);
        string DeleteConfigurationCity(int Id_City);
        string GetConfigurationCity(int Id_State);
        string SetConfigurationColony(int Id_City, string Colony, string PostCode);
        string UpdateConfigurationColony(int Id_Colony, string Colony);
        string DeleteConfigurationColony(int Id_Colony);
        string GetConfigurationColony(int Id_City);
        string GetConfigurationPostCode(int Id_City);

        string SetBaseCatalogsPropertyType(string Descripcion);
        string UpdateBaseCatalogsPropertyType(int id_PropertyType, string Descripcion);
        string DeleteBaseCatalogsPropertyType(int id_PropertyType);
        string GetBaseCatalogsPropertyType();

        string SetBaseCatalogsPropertySubType(string PropertySubType, string Descripcion, int Id_PropertyType);
        string UpdateBaseCatalogsPropertySubType(int id_PropertySubType, string PropertySubType, string Descripcion, int Id_PropertyType);
        string DeleteBaseCatalogsPropertySubType(int id_PropertySubType);
        string GetBaseCatalogsPropertySubType(int id_PropertyType);


        string SetBaseCatalogsTypeOperation(string Operation);
        string UpdateBaseCatalogsTypeOperation(int Id_TypeOperation, string Operation);
        string DeleteBaseCatalogsTypeOperation(int id_PropertyType);
        string GetBaseCatalogsTypeOperation();

        string SetBaseCatalogsGroundType(string GroudType);
        string UpdateBaseCatalogsGroundType(int Id_Ground, string GroudType);
        string DeleteBaseCatalogsGroundType(int Id_Ground);
        string GetBaseCatalogsGroundType();

        string SetBaseCatalogsSector(string Sector);
        string UpdateBaseCatalogsSector(int id_Sector, string Sector);
        string DeleteBaseCatalogsSector(int id_Sector);
        string GetBaseCatalogsSector();

        string GetBaseCatalogsZone(int Id_City);
        string SetBaseCatalogsZone(string zone_name, int Id_City, int Id_Colony);
        string UpdateBaseCatalogsZone(int zone_id, string zone_name, int Id_City);
        string DeleteBaseCatalogsZone(int zone_id);

        string GetBaseCatalogsSource();
        string SetBaseCatalogsSource(string Source);
        string UpdateBaseCatalogsSource(int Id_Source, string Source);
        string DeleteBaseCatalogsSource(int Id_Source);

        string ValidatePropertySubTypeZone(int Id_PropertyType);
        string ValidatePropertyZone(int Id_PropertyType);

        string GetSalesRep();
        string SetSalesRep(string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, string InitialDate, string Title, string URLPhoto, string TaxRef, int Id_Bank, string BankReference);
        string DeleteSalesRep(int Id_SalesRep);
        string GetSalesRepBank();
        string GetUpdateSalesRep(int Id_SalesRep);
        string UpdateSalesRep(int Id_SalesRep, string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_Person, string InitialDate, string Title, string URLPhoto, string TaxRef, int Id_Bank, string BankReference);

        string HCGetOwner();
        string HCGetOwnerSalesRep();
        string DeleteOwner(int Id_Owner);
        string UpdateOwner(int Id_Person, string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_Owner, int Id_SalesRep);
        string SetOwner(string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_SalesRep);
        string GetUpdateOwner(int Id_Owner);
        string HCGetProperty(int Id_PropertyType, int Id_TypeOperation, int Id_State, int Id_City);
        string GetPropertyGroundType();

        string GetUpdatePropertyForRentSale(int Id_Property);
        string GetUpdatePropertyForSale(int Id_Property);
        string GetUpdatePropertyForRent(int Id_Property);

        string UpdatePropertyForRentSale(int Id_Property,int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private);
        string UpdatePropertyForSale    (int Id_Property,int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden,int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner,string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private);
        string UpdatePropertyForRent    (int Id_Property, int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private);

        string SetPropertyForRentSale   (int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string año, string mes, string dia, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private);
        string SetPropertyForSaleRent   (int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private);
        string SetPropertyForSale       (int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner,string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private);
        string SetPropertyForRent       (int Id_City,string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private);

        string DeleteProperty           (int Id_Property);
        string GetPropertyCurrency      ();       
        string GetPropertyZone          (int Id_Colony);
        string GetPropertySubTypee      (int Id_Property);

        string GetPropertyImages(int Id_Property);
        string UpdatePropertyImages(  string MimeType, string Principal, string Description, string Url, int Id_Property, string MimeType1, string Principal1, string Description1, string Url1, string MimeType2, string Principal2, string Description2, string Url2, string MimeType3, string Principal3, string Description3, string Url3);
        string GetPropertyKey();

        string GetRolesForUser(int Id_User);
        string SetRol(string name,string Description);
        string UpdateRol(int Id_Rol,string name, string Description);
        string GetUpdateRol(int Id_Rol);
        string DeleteRol(int Id_User);
        string GetRoles(int Id_User);
        string SetUser(string NameUser,string FullName,string IsEnabled,string Email,string Passsword);
        string SetRolUser(int Id_User,int Id_Role);
        string UpdateUser(int Id_User,string NameUser, string FullName, string IsEnabled, string Email, string Passsword);
        string GetUpdateUser(int Id_User);
        string DeleteRolUser(int Id_User);
        string DeleteUser(int Id_User);
        

    }
}
