using InmobiliariasHomeCo.Abstract.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Security;
using System.Data.SqlClient;
using System.Data;

namespace InmobiliariasHomeCo.Concret.SQL.Modules
{
    public class DataAccessModulesSQL : IDataAccessModules
    {
        public string GetAllModules()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetAllModules";

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

        public Module[] GetPermissionModule(DatesSecurity datesSecurity)
        {
            string IdModule = string.Empty;
            for( int x = 0; x < datesSecurity.Modules.Length; x++)
            {
                IdModule = datesSecurity.Modules[x].IdModule;

            }
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_GetModulePermits";
                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@Id_User", datesSecurity.IdUser));
                command.Parameters.Add(new SqlParameter("@Id_Module", IdModule));
                

                List<Module> listModule = new List<Module>();
                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    Module module = new Module();
                    
                    while (dr.Read())
                    {
                        module = new Module()
                        {
                            NumberPermits = int.Parse(dr["NumberPermits"].ToString())
                        };
                        listModule.Add(module);

                    }
                    return listModule.ToArray();
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return null;
                }

            }
        }

        bool IDataAccessModules.AssignmentOfModuleByRole(DatesSecurity dates)
        { 
            Boolean result = false;
            

            foreach (Module module in dates.Modules)
            {
                using (SqlConnection connection = new SqlConnection(App.ConnectionString))
                {
                    connection.Open();
                    string query = "sp_AssignmentOfModuleByRole";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@IdRole", dates.IdRole));
                    command.Parameters.Add(new SqlParameter("@IdModule", module.IdModule));
                    command.Parameters.Add(new SqlParameter("@NumberPermits", module.NumberPermits));

                    try
                    {
                        SqlDataReader dr = command.ExecuteReader();
                        string json = "";
                        while (dr.Read())
                        {
                            json += dr.GetValue(0).ToString();
                            
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

            return false;
        }
    }
}
