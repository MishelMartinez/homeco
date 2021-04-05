using InmobiliariasHomeCo.Abstract.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Security;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace InmobiliariasHomeCo.Concret.SQL.Security
{
    public class DataAccessSecuritySQL : IDataAccessSecurity
    {
        public string GetModulesNavbarJson(DatesSecurity datesSecurity)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_GetModulesNavbar";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@Client", datesSecurity.User));
                command.Parameters.Add(new SqlParameter("@Pasword", datesSecurity.Password));

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
                    return "NO module";
                }
            }
        }

        public Module[] GetModulesSecurity(DatesSecurity datesSecurity)
        {
            throw new NotImplementedException();
        }

        public int GetPermits(DatesSecurity datesSecurity)
        {
            throw new NotImplementedException();
        }

        //get Permits



        public bool GetStatusUser(DatesSecurity datesSecurity)
        {

            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();

            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(datesSecurity.Password));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }

            Console.WriteLine(hash);

            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_GetValidateUser";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@Client", datesSecurity.User));
                command.Parameters.Add(new SqlParameter("@Pasword", datesSecurity.Password));

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    string json = "";
                    while (dr.Read())
                    {
                        json += dr.GetValue(0).ToString();
                        //return dr.GetValue(0).ToString();
                    }
                    return Boolean.Parse(json);
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return false;
                }
            }
        }

        public bool StatusValidationString(DatesSecurity dates)
        {
            //stringSecurity = stringSecurity.Substring(16, stringSecurity.Length - 17);


            byte[] byteArray = Convert.FromBase64String(dates.Base);

            string jsonBack = Encoding.UTF8.GetString(byteArray);


            string[] lines = Regex.Split(jsonBack, "&");

            DateTime dateTime = DateTime.Parse(lines[2]);

            



            int result = DateTime.Compare(DateTime.Now, dateTime);

            if (result < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        DatesSecurity IDataAccessSecurity.GetStatusUser(DatesSecurity datesSecurity)
        {
          
                using (SqlConnection connection = new SqlConnection(App.ConnectionString))
                {

                    connection.Open();
                    string query = "sp_GetValidateUser";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    DatesSecurity datesUser = new DatesSecurity();

                    command.Parameters.Add(new SqlParameter("@Client", datesSecurity.User));
                    command.Parameters.Add(new SqlParameter("@Pasword", datesSecurity.Password));
                   
                    try
                    {
                        SqlDataReader dr = command.ExecuteReader();
                       
                        while (dr.Read())
                        {
                            datesUser = new DatesSecurity()
                            {
                                IdUser = dr["Id_User"].ToString(),
                                Status = Boolean.Parse(dr["Access"].ToString())

                            };
                           
                        }
                     return datesUser;

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
