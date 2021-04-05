
using InmobiliariasHomeCo.Abstract.Roles;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Roles;

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

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        Entities.Roles.Role role = new Entities.Roles.Role()
                        {
                            IdRole  = int.Parse(dr["IdRole"].ToString()),
                            Name    =           dr["Name"].ToString()

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
    }
}
