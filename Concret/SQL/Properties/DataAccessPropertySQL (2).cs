using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using InmobiliariasHomeCo.Abstract.Properties;
using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Currencies;
using InmobiliariasHomeCo.Entities.Locations;
using InmobiliariasHomeCo.Entities.Persons.Owners;
using InmobiliariasHomeCo.Entities.Properties;
using InmobiliariasHomeCo.Entities.Properties.Locations;
using System.Net.Mail;
using System.Net;
using InmobiliariasHomeCo.Entities.Pojos.Search;
using InmobiliariasHomeCo.Entities.Pojos.Properties;

namespace InmobiliariasHomeCo.Concret.Mock.Properties
{
    public class DataAccessPropertySQL : IDataAccessProperty
    {
        public string AdShCity(int Id_State)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShCity";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string AdShColony(int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShColony";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string AdShPropertySubType(int IdTypeOperation)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShPropertySubType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", IdTypeOperation));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string AdShPropertyType(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShPropertyType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string AdShState(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string AdShTypeOperation(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShTypeOperation";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string AdShZone(int Id_Colony, int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsGroundType(int Id_Ground)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsGroundType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsPropertySubType(int id_PropertySubType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsPropertySubType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id_PropertySubType", id_PropertySubType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsPropertyType(int id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsPropertyType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", id_PropertyType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsSector(int id_Sector)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsSector";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Sector", id_Sector));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsSource(int Id_Source)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsSource";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Source", Id_Source));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsTypeOperation(int id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsTypeOperation";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_TypeOperation", id_PropertyType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string DeleteBaseCatalogsZone(int zone_id)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteBaseCatalogsZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@zone_id", zone_id));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string DeleteConfigurationCity(int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteConfigurationCity";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string DeleteConfigurationColony(int Id_Colony)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteConfigurationColony";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string DeleteConfigurationState(int Id_State)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteConfigurationState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string DeleteOwner(int Id_Owner)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteOwner";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string DeleteProperty(int Id_Property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteProperty";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string DeleteSalesRep(int Id_SalesRep)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_DeleteSalesRep";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string GetAdShAdvancedSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShAdvancedSearchPropertyForRent";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PriceMax", PriceMax));
                command.Parameters.Add(new SqlParameter("@PriceMin", PriceMin));
                command.Parameters.Add(new SqlParameter("@NumRooms", NumRooms));
                command.Parameters.Add(new SqlParameter("@NumBath", NumBath));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetAdShAdvancedSearchPropertyForRentSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShAdvancedSearchPropertyForRentSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PriceMax", PriceMax));
                command.Parameters.Add(new SqlParameter("@PriceMin", PriceMin));
                command.Parameters.Add(new SqlParameter("@NumRooms", NumRooms));
                command.Parameters.Add(new SqlParameter("@NumBath", NumBath));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetAdShAdvancedSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int NumRooms, int NumBath, int Id_PropertyType, int Id_PropertySubType, string Furnished)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShAdvancedSearchPropertyForSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PriceMax", PriceMax));
                command.Parameters.Add(new SqlParameter("@PriceMin", PriceMin));
                command.Parameters.Add(new SqlParameter("@NumRooms", NumRooms));
                command.Parameters.Add(new SqlParameter("@NumBath", NumBath));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetAdShSearchPropertyForRent(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShSearchPropertyForRent";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City",   Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PriceMax",  PriceMax));
                command.Parameters.Add(new SqlParameter("@PriceMin",  PriceMin));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetAdShSearchPropertyForRentSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShSearchPropertyForRentSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PriceMax", PriceMax));
                command.Parameters.Add(new SqlParameter("@PriceMin", PriceMin));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetAdShSearchPropertyForSale(int Id_City, int Id_Colony, int PriceMax, int PriceMin, int Id_PropertyType, int Id_PropertySubType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAdShSearchPropertyForSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PriceMax", PriceMax));
                command.Parameters.Add(new SqlParameter("@PriceMin", PriceMin));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsGroundType()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsGroundType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsPropertySubType(int id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsPropertySubType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id_PropertyType", id_PropertyType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsPropertyType()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsPropertyType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsSector()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsSector";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsSource()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsSource";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsTypeOperation()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsTypeOperation";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetBaseCatalogsZone(int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetBaseCatalogsZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetConfigurationCity(int Id_State)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "GetConfigurationCity";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetConfigurationColony(int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetConfigurationColony";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetConfigurationCountry(int Key)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetConfigurationCountry";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetConfigurationPostCode(int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetConfigurationPostCode";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetConfigurationState(int Id_State)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetConfigurationState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetConfigurationStates(int Id_Country)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetConfigurationStates";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Country", Id_Country));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetDataSheetAdrees(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetDataSheetAdrees";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Property_id", IdProperty));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetDataSheetImages(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetDataSheetImages";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Property_id", IdProperty));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetDataSheetSpace(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetDataSheetSpace";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Property_id", IdProperty));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public Property[] GetProperties()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Property"; //Crear una consulta entre varias tablas

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                List<Property> properties = null;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    properties = new List<Property>();
                    while (dr.Read())
                    {
                        Property property = new Property()
                        {
                            IdProperty = int.Parse(dr["Id_Property"].ToString()),
                            PropertyKey = dr["PropertyKey"].ToString(),
                            CaptureDate = DateTime.Parse(dr["CaptureDate"].ToString()),
                            Characteristics = new PropertyCharacteristics()
                            {
                                Address = new Address()
                                {
                                    City = new City()
                                    {
                                        Name = dr["CityName"].ToString(),
                                        State = new State()
                                        {
                                            Name = dr["State"].ToString()
                                        }
                                    },
                                    Colony = new Colony()
                                    {
                                        Name = dr["Colony"].ToString(),
                                        CodePost = dr["PostCode"].ToString()
                                    },
                                    Country = new Country()
                                    {
                                        Name = dr["Country"].ToString(),
                                    }
                                }
                            },
                            Owner = new Owner()
                            {
                                Name = dr["Parent"].ToString(),
                                PhoneNumber = dr["PhoneNumber"].ToString()
                            },
                            Currency = new Currency()
                            {
                                Description = dr["Currency"].ToString()
                            },
                            PropertyImages = new PropertyImage[] {
                                new PropertyImage() {
                                Url = dr["Url"].ToString(),
                                Description = dr["Description"].ToString()
                                    }
                             }
                        };

                        properties.Add(property);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return properties.ToArray();
            }
        }

        public string GetPropertiesTechnicalSheet(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetDataSheet";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Property_id", IdProperty));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public PropertyTest[] GetPropertiesTest()
        {
            List<PropertyTest> properties = new List<PropertyTest>();

            // Rent
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "SELECT *,(SELECT CityName FROM City WHERE Id_City=[Address].Id_City) AS City, " +
                               "(SELECT Colony FROM Colony WHERE Id_Colony=[Address].Id_Colony) AS Colony, "+
                               "(SELECT [State] FROM [State] WHERE Id_State=(SELECT Id_State FROM City WHERE Id_City=[Address].Id_City)) AS [State] "+
                               "FROM  [Property],[Address],[Space],[PropertyForRent],[PropertiesImages] "+
                               "WHERE [Property].Id_Property = [Space].Id_Property "+
                               "AND   [Property].Id_Property = [PropertyForRent].Id_Property "+
                               "AND   [Property].Id_Address  = [Address].Id_Address "+
                               "AND   [Property].Id_Property  = [PropertiesImages].Id_Property "+
                               "AND   [PropertiesImages].Principal = 1";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        PropertyTest property = new PropertyTest()
                        {
                            state = "Casa",
                            price = dr["MonthlyRent"].ToString(),
                            partnernumber = dr["PropertyKey"].ToString(),
                            img = dr["Url"].ToString(),
                            size = dr["Area"].ToString(),
                            numberbathrooms = int.Parse(dr["Bath"].ToString()),
                            numberrooms = int.Parse(dr["Rooms"].ToString()),
                            //firstname       = dr["PhoneNumber"].ToString(),
                            zona = dr["Street"].ToString(),
                            Location        = String.Format("{0} {1}", dr["City"].ToString(), dr["Colony"].ToString()),
                            estado          = dr["State"].ToString(),
                            rentaventa = "Renta"
                        };

                        properties.Add(property);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }

            // Sale
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "SELECT *,(SELECT CityName FROM City WHERE Id_City=[Address].Id_City) AS City, "+
                               "(SELECT Colony FROM Colony WHERE Id_Colony=[Address].Id_Colony) AS Colony, "+
		                       "(SELECT [State] FROM [State] WHERE Id_State=(SELECT Id_State FROM City WHERE Id_City=[Address].Id_City)) AS [State] "+
                               "FROM [Property],[Address],[Space],[PropertyForSale],[PropertiesImages] "+
                               "WHERE [Property].Id_Property = [Space].Id_Property "+
                               "AND   [Property].Id_Property = [PropertyForSale].Id_Property "+
                               "AND   [Property].Id_Address  = [Address].Id_Address "+
                               "AND   [Property].Id_Property  = [PropertiesImages].Id_Property "+
                               "AND   [PropertiesImages].Principal = 1";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        PropertyTest property = new PropertyTest()
                        {
                            state           = "Casa",
                            price           = dr["Amount"].ToString(),
                            partnernumber   = dr["PropertyKey"].ToString(),
                            img             = dr["Url"].ToString(),
                            size            = dr["Area"].ToString(),
                            numberbathrooms = int.Parse(dr["Bath"].ToString()),
                            numberrooms     = int.Parse(dr["Rooms"].ToString()),
                            //firstname       = dr["PhoneNumber"].ToString(),
                            zona            = dr["Street"].ToString(),
                            Location        = String.Format("{0} {1}",dr["City"].ToString(), dr["Colony"].ToString()),
                            estado          = dr["State"].ToString(),
                            rentaventa = "Sale"
                        };

                        properties.Add(property);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return properties.ToArray();
        }

        public string GetPropertyCurrency()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertyCurrency";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                   
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetPropertyGroundType()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertyGroudType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetPropertyImages(int Id_Property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertyImages";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_Property));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    if (json == "")
                    {
                        json = "[{\"SinDato\":true}]";
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetPropertyKey()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertyKey";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    if (json == "")
                    {
                        json = "[{\"SinDato\":true}]";
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetPropertySubTypee(int Id_Property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertySubTypee";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_Property));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    if (json == "")
                    {
                        json = "[{\"SinDato\":true}]";
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetPropertyZone(int Id_Colony)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertyZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    if (json == "")
                    {
                        json = "[{\"SinDato\":true}]";
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetSalesRep()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetSalesRep";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetSalesRepBank()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetSalesRepBank";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetShowProperty(int IdProperty)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetShowProperty";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUpdateOwner(int Id_Owner)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUpdateOwner";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUpdatePropertyForRent(int Id_Property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUpdatePropertyForRent";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUpdatePropertyForRentSale(int Id_Property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUpdatePropertyForRentSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUpdatePropertyForSale(int Id_Property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUpdatePropertyForSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUpdateSalesRep(int Id_SalesRep)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUpdateSalesRep";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUsers(int Key)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUsers";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetUsersRol(int Key)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetUsersRol";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string GetZone(StateMessage stateMessage)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetStateZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@Id_State", stateMessage.Id));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();

                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }

        }

        public string GetZones()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string HCGetOwner()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetOwner";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string HCGetOwnerSalesRep()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetOwnerSalesRep";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string HCGetProperty(int Id_PropertyType, int Id_TypeOperation, int Id_State, int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetProperty";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_TypeOperation", Id_TypeOperation));
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    string dato = json;
                    int cont1;
                    int año, mes, dia;
                    for (int i = 0;i<json.Length;i++){
                        dato = json.Substring(i, 1);
                        if(dato == "F"){
                            if (json.Substring(i, 8) == "Fecha\":\""){
                                i = (i + 8);
                                cont1 = i;
                                año = int.Parse( json.Substring(i, 4) );
                                i = i + 5;
                                mes = int.Parse(json.Substring(i, 2));
                                i = i + 3;
                                dia = int.Parse(json.Substring(i, 2));
                                i = i + 11;

                                DateTime oldDate = new DateTime(año, mes, dia);
                                DateTime newDate = DateTime.Now;

                                // Difference in days, hours, and minutes.
                                TimeSpan ts = newDate - oldDate;

                                // Difference in days.
                                int differenceInDays = ts.Days;

                                json = json.Substring(0, cont1) + differenceInDays + json.Substring(i, (json.Length-i));

                                //Console.WriteLine(json);
                            }
                        }
                    }
                    

                    Console.Write("");
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public Property InsertProperty(Property property)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                /*if (property != null)
                {
                    connection.Open();

                    string query = "INSERT INTO Client (Parent,PhoneNumber,MovilNumber,Email,RegDate,BirthDate,MaritalStatus,Gender,NumChildren) " +
                                   "VALUES " +
                                   "(@Parent,@PhoneNumber,@MovilNumber,@Email,@RegDate,@BirthDate,@MaritalStatus,@Gender,@NumChildren); " +
                                   "SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.Add("@Parent", SqlDbType.VarChar, 50).Value = client.Parent;
                    command.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = client.PhoneNumber;
                    command.Parameters.Add("@MovilNumber", SqlDbType.VarChar).Value = client.MobilNumber;
                    command.Parameters.Add("@Email", SqlDbType.VarChar, 50).Value = client.Email;
                    command.Parameters.Add("@RegDate", SqlDbType.DateTime).Value = client.RegDate;
                    command.Parameters.Add("@BirthDate", SqlDbType.DateTime).Value = client.BirthDate;
                    command.Parameters.Add("@MaritalStatus", SqlDbType.VarChar, 50).Value = client.MaritalStatus;
                    command.Parameters.Add("@Gender", SqlDbType.VarChar, 100).Value = client.Gender;
                    command.Parameters.Add("@NumChildren", SqlDbType.Int).Value = client.ChildrenNUmber;

                    try
                    {
                        client.Id = int.Parse(command.ExecuteScalar().ToString());
                    }
                    catch (Exception ex)
                    {
                        return null;
                    }
                    return client;
                }*/
            }
            return null;
        }

        public string SearchProperty(PropertyMessage propertyMessage)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetPropertyForCustomer";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Id_PropertyType ", propertyMessage.IdPropertyType));
                command.Parameters.Add(new SqlParameter("@Id_TypeOperation", int.Parse(propertyMessage.TypeOperation)));
                command.Parameters.Add(new SqlParameter("@Id_State", propertyMessage.IdState));
                command.Parameters.Add(new SqlParameter("@zone_id", propertyMessage.IdZone));
                command.Parameters.Add(new SqlParameter("@PropertyKey", propertyMessage.PropertyKey));
                command.Parameters.Add(new SqlParameter("@GroudType", propertyMessage.IdCountry));

                
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsGroundType(string GroudType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsGroundType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@GroudType", GroudType));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsPropertySubType(string PropertySubType, string Descripcion, int Id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsPropertySubType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@PropertySubType", PropertySubType));
                command.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsPropertyType(string Descripcion)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsPropertyType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsSector(string Sector)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsSector";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Sector", Sector));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsSource(string Source)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsSource";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@source", Source));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsTypeOperation(string Operation)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsTypeOperation";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Operation", Operation));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetBaseCatalogsZone(string zone_name, int Id_City, int Id_Colony)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetBaseCatalogsZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@zone_name", zone_name));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetConfigurationCity(int Id_State, string CityName)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetConfigurationCity";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                command.Parameters.Add(new SqlParameter("@CityName", CityName));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string SetConfigurationColony(int Id_City, string Colony, string PostCode)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetConfigurationColony";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Colony", Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetConfigurationState(int Id_Country, string State)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetConfigurationState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Country", Id_Country));
                command.Parameters.Add(new SqlParameter("@State", State));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetContact(string Nombre, string Email, string Asunto, string Mensaje)
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("zuger.ger@gmail.com"));
            email.From = new MailAddress("zuger.ger@gmail.com");
            email.Subject = Asunto+ " ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            email.Body = "Nombre : "+Nombre+"\nEmail : "+Email+"\nMensaje : " + Mensaje ;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("zuger.ger@gmail.com", "zuger5820A");

            string output = "";
            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);

            

            return output;

            
        }

        public string SetOwner(string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_SalesRep)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetOwner";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegDate", RegDate));
                command.Parameters.Add(new SqlParameter("@Name", Name));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@MobilNumber", MobilNumber));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                command.Parameters.Add(new SqlParameter("@BirthDate", BirthDate));
                command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
                command.Parameters.Add(new SqlParameter("@Id_Gender", Id_Gender));
                command.Parameters.Add(new SqlParameter("@ChildrenNUmber", ChildrenNUmber));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetPropertyForRent(int Id_City,string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetPropertyForRent";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber", OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber", InteriorNumber));
                command.Parameters.Add(new SqlParameter("@MonthlyRent", MonthlyRent));
                command.Parameters.Add(new SqlParameter("@Id_Currency", Id_Currency));
                command.Parameters.Add(new SqlParameter("@CurrentMaintenance", CurrentMaintenance));
                command.Parameters.Add(new SqlParameter("@DepositsMonths", DepositsMonths));
                command.Parameters.Add(new SqlParameter("@TaxReceipt", TaxReceipt));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                command.Parameters.Add(new SqlParameter("@Guarantor", Guarantor));
                command.Parameters.Add(new SqlParameter("@LegalPolicy", LegalPolicy));
                command.Parameters.Add(new SqlParameter("@Other1", Other1));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CaptureDate", CaptureDate));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));
                command.Parameters.Add(new SqlParameter("@MimeType", MimeType));
                command.Parameters.Add(new SqlParameter("@Principal", Principal));
                command.Parameters.Add(new SqlParameter("@Description1", Description1));
                command.Parameters.Add(new SqlParameter("@Url", Url));
                
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetPropertyForRentSale(int Id_City,string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string año, string mes, string dia, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetPropertyForRentSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber",OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber",InteriorNumber));
                command.Parameters.Add(new SqlParameter("@MonthlyRent", MonthlyRent));
                command.Parameters.Add(new SqlParameter("@Id_Currency", Id_Currency));
                command.Parameters.Add(new SqlParameter("@CurrentMaintenance", CurrentMaintenance));
                command.Parameters.Add(new SqlParameter("@DepositsMonths", DepositsMonths));
                command.Parameters.Add(new SqlParameter("@TaxReceipt", TaxReceipt));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                command.Parameters.Add(new SqlParameter("@Guarantor", Guarantor));
                command.Parameters.Add(new SqlParameter("@LegalPolicy", LegalPolicy));
                command.Parameters.Add(new SqlParameter("@Other1", Other1));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));
                command.Parameters.Add(new SqlParameter("@PriceM2", PriceM2));
                command.Parameters.Add(new SqlParameter("@DeliveryPeriod", DeliveryPeriod));
                command.Parameters.Add(new SqlParameter("@Advance", Advance));
                command.Parameters.Add(new SqlParameter("@Builder", Builder));
                command.Parameters.Add(new SqlParameter("@Development", Development));
                command.Parameters.Add(new SqlParameter("@DirectOwner", DirectOwner));
                command.Parameters.Add(new SqlParameter("@Other", Other));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CaptureDate", año));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));
                command.Parameters.Add(new SqlParameter("@MimeType", MimeType));
                command.Parameters.Add(new SqlParameter("@Principal", Principal));
                command.Parameters.Add(new SqlParameter("@Description1", Description1));
                command.Parameters.Add(new SqlParameter("@Url", Url));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetPropertyForSale(int Id_City,string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner,string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetPropertyForSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber", OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber", InteriorNumber));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));
                command.Parameters.Add(new SqlParameter("@PriceM2", PriceM2));
                command.Parameters.Add(new SqlParameter("@DeliveryPeriod", DeliveryPeriod));
                command.Parameters.Add(new SqlParameter("@Advance", Advance));
                command.Parameters.Add(new SqlParameter("@Builder", Builder));
                command.Parameters.Add(new SqlParameter("@Development", Development));
                command.Parameters.Add(new SqlParameter("@DirectOwner", DirectOwner));
                command.Parameters.Add(new SqlParameter("@Other", Other));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CaptureDate", CaptureDate));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));
                command.Parameters.Add(new SqlParameter("@MimeType", MimeType));
                command.Parameters.Add(new SqlParameter("@Principal", Principal));
                command.Parameters.Add(new SqlParameter("@Description1", Description1));
                command.Parameters.Add(new SqlParameter("@Url", Url));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetPropertyForSaleRent(int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetPropertyForRentSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber", OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber", InteriorNumber));
                CaptureDate = CaptureDate.Substring(0, 19);
                command.Parameters.Add(new SqlParameter("@CaptureDate", CaptureDate));
                command.Parameters.Add(new SqlParameter("@Id_Address", Id_Address));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@CurrentMaintenance", CurrentMaintenance));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@Id_Currency", Id_Currency));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@MonthlyRent", MonthlyRent));
                command.Parameters.Add(new SqlParameter("@Conditions", Conditions));
                command.Parameters.Add(new SqlParameter("@DepositsMonths", DepositsMonths));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));
                command.Parameters.Add(new SqlParameter("@PriceM2", PriceM2));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@TaxReceipt", TaxReceipt));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                command.Parameters.Add(new SqlParameter("@Guarantor", Guarantor));
                command.Parameters.Add(new SqlParameter("@LegalPolicy", LegalPolicy));
                command.Parameters.Add(new SqlParameter("@Other1", Other1));
                command.Parameters.Add(new SqlParameter("@DeliveryPeriod", DeliveryPeriod));
                command.Parameters.Add(new SqlParameter("@Advance   ", Advance));
                command.Parameters.Add(new SqlParameter("@Builder", Builder));
                command.Parameters.Add(new SqlParameter("@Development", Development));
                command.Parameters.Add(new SqlParameter("@DirectOwner", DirectOwner));
                command.Parameters.Add(new SqlParameter("@Other", Other));
                command.Parameters.Add(new SqlParameter("@MimeType", MimeType));
                command.Parameters.Add(new SqlParameter("@Principal", Principal));
                command.Parameters.Add(new SqlParameter("@Description1", Description1));
                command.Parameters.Add(new SqlParameter("@Url", Url));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetSalesRep(string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, string InitialDate, string Title, string URLPhoto, string TaxRef, int Id_Bank, string BankReference)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetSalesRep";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@RegDate", RegDate));
                command.Parameters.Add(new SqlParameter("@Parent", Name));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@MobilNumber", MobilNumber));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                command.Parameters.Add(new SqlParameter("@BirthDate", BirthDate));
                command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
                command.Parameters.Add(new SqlParameter("@Id_Gender", Id_Gender));
                command.Parameters.Add(new SqlParameter("@ChildrenNUmber", ChildrenNUmber));
                command.Parameters.Add(new SqlParameter("@InitialDate", InitialDate));
                command.Parameters.Add(new SqlParameter("@Title", Title));
                URLPhoto = URLPhoto + "";
                command.Parameters.Add(new SqlParameter("@URLPhoto", URLPhoto));
                command.Parameters.Add(new SqlParameter("@TaxRef", TaxRef));
                command.Parameters.Add(new SqlParameter("@Id_Bank", Id_Bank));
                command.Parameters.Add(new SqlParameter("@BankReference", BankReference));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string SetUsers(string UserName, int Id_Rol, string FullName, string CreateDate, bool IsEnabled, bool IsAdminBms, string Email)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetUser";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@UserName", UserName));
                command.Parameters.Add(new SqlParameter("@Id_Rol", Id_Rol));
                command.Parameters.Add(new SqlParameter("@FullName", FullName));
                command.Parameters.Add(new SqlParameter("@CreateDate", CreateDate));
                command.Parameters.Add(new SqlParameter("@IsEnabled", IsEnabled));
                command.Parameters.Add(new SqlParameter("@IsAdminBms", IsAdminBms));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                return null;
                
            }
        }

        public string UpdateBaseCatalogsGroundType(int Id_Ground, string GroudType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsGroundType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@GroudType", GroudType));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateBaseCatalogsPropertySubType(int id_PropertySubType, string PropertySubType, string Descripcion, int Id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsPropertySubType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id_PropertySubType", id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@PropertySubType", PropertySubType));
                command.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateBaseCatalogsPropertyType(int id_PropertyType, string Descripcion)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsPropertyType";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@id_PropertyType", id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Descripcion", Descripcion));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateBaseCatalogsSector(int id_Sector, string Sector)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsSector";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Sector", id_Sector));
                command.Parameters.Add(new SqlParameter("@Sector", Sector));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateBaseCatalogsSource(int Id_Source, string Source)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsSource";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Source", Id_Source));
                command.Parameters.Add(new SqlParameter("@source", Source));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateBaseCatalogsTypeOperation(int Id_TypeOperation, string Operation)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsTypeOperation";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_TypeOperation", Id_TypeOperation));
                command.Parameters.Add(new SqlParameter("@Operation", Operation));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateBaseCatalogsZone(int zone_id, string zone_name, int Id_City)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateBaseCatalogsZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@zone_id", zone_id));
                command.Parameters.Add(new SqlParameter("@zone_name", zone_name));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateConfigurationCity(int Id_City, string CityName)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateConfigurationCity";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CityName", CityName));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateConfigurationColony(int Id_Colony, string Colony)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateConfigurationColony";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@Colony", Colony));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }
    

        public string UpdateConfigurationState(int Id_State, string State)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateConfigurationState";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_State", Id_State));
                command.Parameters.Add(new SqlParameter("@State", State));
                string Verificacion = "UpdateState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateOwner(int Id_Person, string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_Owner, int Id_SalesRep)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateOwner";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Person ", Id_Person));
                command.Parameters.Add(new SqlParameter("@RegDate", RegDate));
                command.Parameters.Add(new SqlParameter("@Parent", Name));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@MobilNumber", MobilNumber));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                command.Parameters.Add(new SqlParameter("@BirthDate", BirthDate));
                command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
                command.Parameters.Add(new SqlParameter("@Id_Gender", Id_Gender));
                command.Parameters.Add(new SqlParameter("@ChildrenNUmber", ChildrenNUmber));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdatePropertyForRent(int Id_Property,int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string MimeType, string Principal, string Description1, string Url, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string Private)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdatePropertyForRent";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber", OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber", InteriorNumber));
                command.Parameters.Add(new SqlParameter("@MonthlyRent", MonthlyRent));
                command.Parameters.Add(new SqlParameter("@Id_Currency", Id_Currency));
                command.Parameters.Add(new SqlParameter("@CurrentMaintenance", CurrentMaintenance));
                command.Parameters.Add(new SqlParameter("@DepositsMonths", DepositsMonths));
                command.Parameters.Add(new SqlParameter("@TaxReceipt", TaxReceipt));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                command.Parameters.Add(new SqlParameter("@Guarantor", Guarantor));
                command.Parameters.Add(new SqlParameter("@LegalPolicy", LegalPolicy));
                command.Parameters.Add(new SqlParameter("@Other1", Other1));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CaptureDate", CaptureDate));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdatePropertyForRentSale(int Id_Property, int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int MonthlyRent, string Conditions, int DepositsMonths, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string TaxReceipt, string Furnished, string Guarantor, string LegalPolicy, string Other1, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdatePropertyForRentSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber", OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber", InteriorNumber));
                command.Parameters.Add(new SqlParameter("@MonthlyRent", MonthlyRent));
                command.Parameters.Add(new SqlParameter("@Id_Currency", Id_Currency));
                command.Parameters.Add(new SqlParameter("@CurrentMaintenance", CurrentMaintenance));
                command.Parameters.Add(new SqlParameter("@DepositsMonths", DepositsMonths));
                command.Parameters.Add(new SqlParameter("@TaxReceipt", TaxReceipt));
                command.Parameters.Add(new SqlParameter("@Furnished", Furnished));
                command.Parameters.Add(new SqlParameter("@Guarantor", Guarantor));
                command.Parameters.Add(new SqlParameter("@LegalPolicy", LegalPolicy));
                command.Parameters.Add(new SqlParameter("@Other1", Other1));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));
                command.Parameters.Add(new SqlParameter("@PriceM2", PriceM2));
                command.Parameters.Add(new SqlParameter("@DeliveryPeriod", DeliveryPeriod));
                command.Parameters.Add(new SqlParameter("@Advance", Advance));
                command.Parameters.Add(new SqlParameter("@Builder", Builder));
                command.Parameters.Add(new SqlParameter("@Development", Development));
                command.Parameters.Add(new SqlParameter("@DirectOwner", DirectOwner));
                command.Parameters.Add(new SqlParameter("@Other", Other));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CaptureDate", CaptureDate));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));

                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdatePropertyForSale(int Id_Property, int Id_City, string Street, int Id_Colony, string PostCode, string OutdoorNumber, string InteriorNumber, string CaptureDate, int Id_Address, int Id_Owner, int Id_SalesRep, int Id_Ground, int Area, int GardenArea, int Construction, int Levels, int Front, int BackGround, string Description, int AntiguatyYears, string Tank, int CapacityTank, string CurrentPredial, string CurrentMaintenance, string ServicesPayed, int Id_Currency, string FiscalReceipt, int Id_PropertyType, int Id_PropertySubType, string Others, int TypeOperation, int SportFields, int Spit, int Rooms, int Closet, int DressingRoom, int Bath, int MiddleBath, int ServiceCorridor, int ServiceRoom, int Parking, int ParkingVisit, int Cellar, int Kitchen, int FretsSoap, int TvRoom, int StudyRoom, int Bar, int ServiceYard, int MultipleSalon, int Smokestack, int Jacuzzi, int Vat, int Lido, int CommonArea, int HouseClub, int Terrace, int Garden, int Amount, int PriceM2, string FreeDocument, string DocumentNumber, string CurrentCredit, int BalanceCredit, string AssessmentFree, string SaleInLast3years, string OtherLegalStatus, string LightService, string WaterService, string Lamps, string GasService, string SewerSystem, string TelephoneService, string CableService, string Alarm, string ElectricFence, string Policy, string IrrigationSystem, string Nets, string Blinds, string Curtains, string WaterPressure, string AirConditioner, string DeliveryPeriod, int Advance, string Builder, string Development, string DirectOwner, string Other, string MimeType, string Principal, string Description1, string Url, string Private)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdatePropertyForSale";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep));
                command.Parameters.Add(new SqlParameter("@Id_Owner", Id_Owner));
                command.Parameters.Add(new SqlParameter("@Id_Colony", Id_Colony));
                command.Parameters.Add(new SqlParameter("@PostCode", PostCode));
                command.Parameters.Add(new SqlParameter("@Street", Street));
                command.Parameters.Add(new SqlParameter("@OutdoorNumber", OutdoorNumber));
                command.Parameters.Add(new SqlParameter("@InteriorNumber", InteriorNumber));
                command.Parameters.Add(new SqlParameter("@Amount", Amount));
                command.Parameters.Add(new SqlParameter("@PriceM2", PriceM2));
                command.Parameters.Add(new SqlParameter("@DeliveryPeriod", DeliveryPeriod));
                command.Parameters.Add(new SqlParameter("@Advance", Advance));
                command.Parameters.Add(new SqlParameter("@Builder", Builder));
                command.Parameters.Add(new SqlParameter("@Development", Development));
                command.Parameters.Add(new SqlParameter("@DirectOwner", DirectOwner));
                command.Parameters.Add(new SqlParameter("@Other", Other));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                command.Parameters.Add(new SqlParameter("@Id_PropertySubType", Id_PropertySubType));
                command.Parameters.Add(new SqlParameter("@Private", Private));
                command.Parameters.Add(new SqlParameter("@ServicesPayed", ServicesPayed));
                command.Parameters.Add(new SqlParameter("@LightService", LightService));
                command.Parameters.Add(new SqlParameter("@SewerSystem", SewerSystem));
                command.Parameters.Add(new SqlParameter("@WaterService", WaterService));
                command.Parameters.Add(new SqlParameter("@TelephoneService", TelephoneService));
                command.Parameters.Add(new SqlParameter("@CurrentPredial", CurrentPredial));
                command.Parameters.Add(new SqlParameter("@GasService", GasService));
                command.Parameters.Add(new SqlParameter("@CableService", CableService));
                command.Parameters.Add(new SqlParameter("@Area", Area));
                command.Parameters.Add(new SqlParameter("@Construction", Construction));
                command.Parameters.Add(new SqlParameter("@Id_Ground", Id_Ground));
                command.Parameters.Add(new SqlParameter("@AntiguatyYears", AntiguatyYears));
                command.Parameters.Add(new SqlParameter("@Front", Front));
                command.Parameters.Add(new SqlParameter("@BackGround", BackGround));
                command.Parameters.Add(new SqlParameter("@Levels", Levels));
                command.Parameters.Add(new SqlParameter("@GardenArea", GardenArea));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@FiscalReceipt", FiscalReceipt));
                command.Parameters.Add(new SqlParameter("@DocumentNumber", DocumentNumber));
                command.Parameters.Add(new SqlParameter("@FreeDocument", FreeDocument));
                command.Parameters.Add(new SqlParameter("@AssessmentFree", AssessmentFree));
                command.Parameters.Add(new SqlParameter("@BalanceCredit", BalanceCredit));
                command.Parameters.Add(new SqlParameter("@CurrentCredit", CurrentCredit));
                command.Parameters.Add(new SqlParameter("@SaleInLast3years", SaleInLast3years));
                command.Parameters.Add(new SqlParameter("@OtherLegalStatus", OtherLegalStatus));
                command.Parameters.Add(new SqlParameter("@Kitchen", Kitchen));
                command.Parameters.Add(new SqlParameter("@ServiceCorridor", ServiceCorridor));
                command.Parameters.Add(new SqlParameter("@Cellar", Cellar));
                command.Parameters.Add(new SqlParameter("@ServiceRoom", ServiceRoom));
                command.Parameters.Add(new SqlParameter("@Parking", Parking));
                command.Parameters.Add(new SqlParameter("@ParkingVisit", ParkingVisit));
                command.Parameters.Add(new SqlParameter("@Rooms", Rooms));
                command.Parameters.Add(new SqlParameter("@Closet", Closet));
                command.Parameters.Add(new SqlParameter("@DressingRoom", DressingRoom));
                command.Parameters.Add(new SqlParameter("@Bath", Bath));
                command.Parameters.Add(new SqlParameter("@MiddleBath", MiddleBath));
                command.Parameters.Add(new SqlParameter("@Tank", Tank));
                command.Parameters.Add(new SqlParameter("@CapacityTank", CapacityTank));
                command.Parameters.Add(new SqlParameter("@Garden", Garden));
                command.Parameters.Add(new SqlParameter("@Terrace", Terrace));
                command.Parameters.Add(new SqlParameter("@FretsSoap", FretsSoap));
                command.Parameters.Add(new SqlParameter("@Spit", Spit));
                command.Parameters.Add(new SqlParameter("@TvRoom", TvRoom));
                command.Parameters.Add(new SqlParameter("@Lamps", Lamps));
                command.Parameters.Add(new SqlParameter("@StudyRoom", StudyRoom));
                command.Parameters.Add(new SqlParameter("@Nets", Nets));
                command.Parameters.Add(new SqlParameter("@Bar", Bar));
                command.Parameters.Add(new SqlParameter("@Smokestack", Smokestack));
                command.Parameters.Add(new SqlParameter("@Blinds", Blinds));
                command.Parameters.Add(new SqlParameter("@Jacuzzi", Jacuzzi));
                command.Parameters.Add(new SqlParameter("@Curtains", Curtains));
                command.Parameters.Add(new SqlParameter("@Vat", Vat));
                command.Parameters.Add(new SqlParameter("@Alarm", Alarm));
                command.Parameters.Add(new SqlParameter("@WaterPressure", WaterPressure));
                command.Parameters.Add(new SqlParameter("@ElectricFence", ElectricFence));
                command.Parameters.Add(new SqlParameter("@Lido", Lido));
                command.Parameters.Add(new SqlParameter("@Policy", Policy));
                command.Parameters.Add(new SqlParameter("@AirConditioner", AirConditioner));
                command.Parameters.Add(new SqlParameter("@ServiceYard", ServiceYard));
                command.Parameters.Add(new SqlParameter("@SportFields", SportFields));
                command.Parameters.Add(new SqlParameter("@CommonArea", CommonArea));
                command.Parameters.Add(new SqlParameter("@MultipleSalon", MultipleSalon));
                command.Parameters.Add(new SqlParameter("@IrrigationSystem", IrrigationSystem));
                command.Parameters.Add(new SqlParameter("@HouseClub", HouseClub));
                command.Parameters.Add(new SqlParameter("@Id_City", Id_City));
                command.Parameters.Add(new SqlParameter("@CaptureDate", CaptureDate));
                command.Parameters.Add(new SqlParameter("@Others", Others));
                command.Parameters.Add(new SqlParameter("@TypeOperation", TypeOperation));

                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdatePropertyImages(string MimeType, string Principal, string Description, string Url, int Id_Property, string MimeType1, string Principal1, string Description1, string Url1, string MimeType2, string Principal2, string Description2, string Url2, string MimeType3, string Principal3, string Description3, string Url3)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdatePropertyImages";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@MimeType", MimeType));
                command.Parameters.Add(new SqlParameter("@Principal", Principal));
                command.Parameters.Add(new SqlParameter("@Description", Description));
                command.Parameters.Add(new SqlParameter("@Url", Url));
                command.Parameters.Add(new SqlParameter("@Id_Property", Id_Property));
                command.Parameters.Add(new SqlParameter("@MimeType1", MimeType1));
                command.Parameters.Add(new SqlParameter("@Principal1", Principal1));
                command.Parameters.Add(new SqlParameter("@Description1", Description1));
                command.Parameters.Add(new SqlParameter("@Url1", Url1));
                command.Parameters.Add(new SqlParameter("@MimeType2", MimeType2));
                command.Parameters.Add(new SqlParameter("@Principal2", Principal2));
                command.Parameters.Add(new SqlParameter("@Description2", Description2));
                command.Parameters.Add(new SqlParameter("@Url2", Url2));
                command.Parameters.Add(new SqlParameter("@MimeType3", MimeType3));
                command.Parameters.Add(new SqlParameter("@Principal3", Principal3));
                command.Parameters.Add(new SqlParameter("@Description3", Description3));
                command.Parameters.Add(new SqlParameter("@Url3", Url3));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string UpdateSalesRep(int Id_SalesRep, string RegDate, string Name, string PhoneNumber, string MobilNumber, string Email, string BirthDate, string MaritalStatus, int Id_Gender, int ChildrenNUmber, int Id_Person, string InitialDate, string Title, string URLPhoto, string TaxRef, int Id_Bank, string BankReference)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_UpdateSalesRep";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_Person ", Id_Person));
                command.Parameters.Add(new SqlParameter("@RegDate", RegDate));
                command.Parameters.Add(new SqlParameter("@Parent", Name));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", PhoneNumber));
                command.Parameters.Add(new SqlParameter("@MobilNumber", MobilNumber));
                command.Parameters.Add(new SqlParameter("@Email", Email));
                command.Parameters.Add(new SqlParameter("@BirthDate", BirthDate));
                command.Parameters.Add(new SqlParameter("@MaritalStatus", MaritalStatus));
                command.Parameters.Add(new SqlParameter("@Id_Gender", Id_Gender));
                command.Parameters.Add(new SqlParameter("@ChildrenNUmber", ChildrenNUmber));
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", Id_SalesRep)); 
                command.Parameters.Add(new SqlParameter("@InitialDate", InitialDate));
                command.Parameters.Add(new SqlParameter("@Title", Title));
                command.Parameters.Add(new SqlParameter("@URLPhoto", URLPhoto));
                command.Parameters.Add(new SqlParameter("@TaxRef", TaxRef));
                command.Parameters.Add(new SqlParameter("@Id_Bank", Id_Bank));
                command.Parameters.Add(new SqlParameter("@BankReference", BankReference));
                string Verificacion = "SetState";
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        public string ValidatePropertySubTypeZone(int Id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_ValidatePropertySubTypeZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public string ValidatePropertyZone(int Id_PropertyType)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_ValidatePropertyZone";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", Id_PropertyType));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }
    }
}
