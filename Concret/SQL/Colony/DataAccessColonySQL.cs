using InmobiliariasHomeCo.Abstract.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealEstateHomeCo.Entities.Validations;
using System.Data.SqlClient;
using System.Data;

namespace InmobiliariasHomeCo.Concret.SQL.Colonies
{
    public class DataAccessColonySQL : IDataAccessColony
    {
        public Colony[] GetColonies()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Colony";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                List<Colony> colonies = null;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    colonies = new List<Colony>();
                    while (dr.Read())
                    {
                        Colony colony = new Colony()
                        {
                            IdColony = int.Parse(dr["Id_Colony"].ToString()),
                            Name = dr["CityName"].ToString(),
                            PostCode = dr["PostCode"].ToString(),
                            ZoneID = int.Parse(dr["Zone_ID"].ToString())
                        };

                        colonies.Add(colony);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return colonies.ToArray();
            }
        }
    }
}
