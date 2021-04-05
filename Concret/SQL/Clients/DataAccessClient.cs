using InmobiliariasHomeCo.Abstract.Clients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities;
using System.Data.SqlClient;
using System.Data;
using InmobiliariasHomeCo.Entities.Clients.ParametersOfInterest;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.Pojos.Clients;

namespace InmobiliariasHomeCo.Concret.SQL.Clients
{
    public class DataAccessClient : IDataAccessClient
    {
        public string GetAllClients()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAllClients";

                SqlCommand command = new SqlCommand(query, connection);

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

        public int RegisterClient(Client client)
        {
            int IdClient = 0;
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_RegisterClient";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("Name", client.BusinessPartner.Id));
                command.Parameters.Add(new SqlParameter("PhoneNumber", client.PhoneNumber));
                command.Parameters.Add(new SqlParameter("MobilNumber", client.MobilNumber));
                command.Parameters.Add(new SqlParameter("CreateDate", client.CreateDate=DateTime.Now));
                command.Parameters.Add(new SqlParameter("CivilStatus", client.CivilStatus));
                command.Parameters.Add(new SqlParameter("NumberChildren", client.NumberChildren));


                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    
                    while (dr.Read())
                    {
                        IdClient = int.Parse(dr["IdClient"].ToString());
                        
                    }
                    return IdClient;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    
                }
                return IdClient;
            }
        }

        public bool RegisterkeyInterest(ClientsMessage dates)
        {
            KeyInterest[] keyInterest = dates.keyInterest;

            

            Boolean result = false;
            foreach (KeyInterest keys in keyInterest)
            {
                using (SqlConnection connection = new SqlConnection(App.ConnectionString))
                {

                    connection.Open();
                    string query = "sp_RegisterkeyInterest";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.Add(new SqlParameter("@IdUser", dates.IdUser));
                    command.Parameters.Add(new SqlParameter("@IdKey", keys.Id));
                    
                    




                    try
                    {
                        SqlDataReader dr = command.ExecuteReader();
                        string json = "";
                        while (dr.Read())
                        {
                            json += dr.GetValue(0).ToString();
                            //return dr.GetValue(0).ToString();
                        }
                        result = Boolean.Parse(json);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        result = false;
                    }


                }
            }
            return result;
        }

        public bool RegisterkeyShopping(ClientsMessage dates)
        {
            KeyShopping[] keyShoppings = dates.keyShopping;



            Boolean result = false;
            foreach (KeyShopping keys in keyShoppings)
            {
                using (SqlConnection connection = new SqlConnection(App.ConnectionString))
                {

                    connection.Open();
                    string query = "sp_RegisterkeyShopping";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.Add(new SqlParameter("@IdUser", dates.IdUser));
                    command.Parameters.Add(new SqlParameter("@IdKey", keys.Id));
                    command.Parameters.Add(new SqlParameter("@RegDate", DateTime.Now));




                    try
                    {
                        SqlDataReader dr = command.ExecuteReader();
                        string json = "";
                        while (dr.Read())
                        {
                            json += dr.GetValue(0).ToString();
                            //return dr.GetValue(0).ToString();
                        }
                        result = Boolean.Parse(json);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        result = false;
                    }


                }
            }
            return result;
        }

        public int RegisterParametersInterest(ClientsMessage dates)
        {
            int IdUser = 0;
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SetCustomer";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_SalesRep", dates.IdBusinessPartner));
                command.Parameters.Add(new SqlParameter("@RegDate", dates.CreateDate = DateTime.Now));
                command.Parameters.Add(new SqlParameter("@PhoneNumber", dates.PhoneNumber));
                command.Parameters.Add(new SqlParameter("@MobilNumber", dates.MobilNumber));
                command.Parameters.Add(new SqlParameter("@Email", dates.Email));
                command.Parameters.Add(new SqlParameter("@BirthDate", dates.BirthDate.ToString("yyyy-MM-ddTHH:mm:ss")));
                command.Parameters.Add(new SqlParameter("@MaritalStatus ", dates.CivilStatus));
                command.Parameters.Add(new SqlParameter("@Id_Gender", dates.Gender));
                command.Parameters.Add(new SqlParameter("@ChildrenNUmber", dates.NumberChildren));

                command.Parameters.Add(new SqlParameter("@MaximumBudget", dates.MaximumBudget));
                command.Parameters.Add(new SqlParameter("@Levels", dates.Levels));
                command.Parameters.Add(new SqlParameter("@Rooms", dates.Bedrooms));
                command.Parameters.Add(new SqlParameter("@Id_Source", dates.IdOrigin));
                command.Parameters.Add(new SqlParameter("@Id_Currency", dates.Coin));
                command.Parameters.Add(new SqlParameter("@Id_PropertyType", dates.TypeProperty));
                command.Parameters.Add(new SqlParameter("@zone_id", dates.Zone));
                command.Parameters.Add(new SqlParameter("@Id_Sector", dates.Sector));





                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();

                        IdUser = int.Parse(dr["IdUser"].ToString());
                       

                    }
                    return IdUser;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);

                }
                return IdUser;
            }
        }
    }
}
