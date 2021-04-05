using InmobiliariasHomeCo.Abstract.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Roles;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.Persons.Users;

namespace InmobiliariasHomeCo.Concret.SQL.Users
{
    public class DataAccessUsers : IDataAccessUsers
    {
    

        public bool AssigmentRoles(DatesSecurity dates)
        {
            Entities.Roles.Role[] Roles = dates.Roles;

            string IdUser = dates.IdUser;

            Boolean result=false;
            foreach (Entities.Roles.Role Rol in Roles)
            {
                using (SqlConnection connection = new SqlConnection(App.ConnectionString))
                {

                    connection.Open();
                    string query = "sp_AssignmentOfRolesByUser";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;


                    command.Parameters.Add(new SqlParameter("@Id_User", dates.IdUser));
                    command.Parameters.Add(new SqlParameter("@Id_Role", Rol.IdRole));




                    try
                    {
                        SqlDataReader dr = command.ExecuteReader();
                        string json = "";
                        while (dr.Read())
                        {
                            json += dr.GetValue(0).ToString();
                            //return dr.GetValue(0).ToString();
                        }
                        result= Boolean.Parse(json);
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex);
                        result= false;
                    }

                    
                }
            }
            return result;

        }

        public Entities.Roles.Role[] EditAssigmentRoles(DatesSecurity dates)
        {
            List<Entities.Roles.Role> listRole = new List<Entities.Roles.Role>();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_EditAssigmentRoles";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@Id_User", dates.IdUser));
              
                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Entities.Roles.Role role = new Entities.Roles.Role()
                        {
                            IdRole      = int.Parse(dr["IdRole"].ToString()),
                            Name        =           dr["Name"].ToString(),
                            Description =           dr["Description"].ToString()
                        };

                        listRole.Add(role);

                    }
                    return listRole.ToArray();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }


            }
        }

        public string GetAllUsers()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_GetAllUsers";

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
                    return "no customers Error";
                }
            }
        }

        public User GetUser(DatesSecurity dates)
        {
            User customer = new User();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetClient";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        customer = new User
                        {
                            Id          = int.Parse(dr["Id_User"].ToString()),
                            NameUser    =           dr["NameUser"].ToString(),
                            FullName    =           dr["FullName"].ToString(),
                            Email       =           dr["Email"].ToString(),
                            Passsword   =           dr["Passsword"].ToString(),
                            CreateDate = DateTime.Parse( dr["CreateDate"].ToString())
                        };
                    }

                    return customer;
                   
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public DatesSecurity RegisterUser(DatesSecurity dates)
        {

            DatesSecurity datesSecurity = new DatesSecurity();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_RegisterUser";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@NameUser", dates.Client.NameUser));
                command.Parameters.Add(new SqlParameter("@FullName", dates.Client.FullName));
                command.Parameters.Add(new SqlParameter("@Email", dates.Client.Email));
                command.Parameters.Add(new SqlParameter("@Passsword", dates.Client.Passsword));
                command.Parameters.Add(new SqlParameter("@CreateDate", dates.Client.CreateDate = DateTime.Now));
                command.Parameters.Add(new SqlParameter("@IsEnabled", dates.Client.StatusEnable));

                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        datesSecurity = new DatesSecurity()
                        {
                            IdUser = dr["Id_User"].ToString()
                        };


                    }
                    return datesSecurity;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return datesSecurity = new DatesSecurity() { IdUser = null };
                }


            }
        }

        public bool UpdateAssigmentRoles(DatesSecurity dates)
        {
            throw new NotImplementedException();
        }
    }
}
