
using InmobiliariasHomeCo.Abstract.Roles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Roles;
using InmobiliariasHomeCo.Entities.Security;
using System.Data;

namespace InmobiliariasHomeCo.Concret.SQL.Role
{
    public class DataAccessRoleSQL : IDataAccessRole
    {
        public Entities.Roles.Role[] AllRoles()
        {
            List<Entities.Roles.Role> lisRole = new List<Entities.Roles.Role>();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_AllRoles";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


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

                        lisRole.Add(role);

                    }
                    return lisRole.ToArray();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public bool DeleteRoles(DatesSecurity dates)
        {
            Boolean result = false;
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_DeleteRole";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@IdRole", dates.IdRole));

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
                    return result;
                }
            }
          }

        public string GetAllRoles()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAllRoles";

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

        public Entities.Roles.Role[] GetRole(DatesSecurity dates)
        {
            List<Entities.Roles.Role> lisRole = new List<Entities.Roles.Role>();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetRole";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("IdRole",dates.IdRole));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        Entities.Roles.Role role = new Entities.Roles.Role()
                        {
                            IdRole          = int.Parse(dr["IdRole"].ToString()),
                            Name            =           dr["Name"].ToString(),
                            Description     =           dr["Description"].ToString()


                        };

                        lisRole.Add(role);

                    }
                    return lisRole.ToArray();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }
            }
        }

        public int RegisterRole(DatesSecurity dates)
        {
            Entities.Roles.Role role = new Entities.Roles.Role();

            for (int x=0;x < dates.Roles.Length; x++)
            {
                role.Name = dates.Roles[x].Name;
                role.Description = dates.Roles[x].Description;
            }
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_RegisterRole";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Name", role.Name));
                command.Parameters.Add(new SqlParameter("@Description", role.Description));

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    int json = 0;

                    while (dr.Read())
                    {
                        json += int.Parse(dr["IdRole"].ToString());


                    }
                    return json;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return 0;
                }
            }
        }
    }
}
