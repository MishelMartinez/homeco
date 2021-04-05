using InmobiliariasHomeCo.Abstract.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Validations;
using System.Data.SqlClient;
using System.Data;

namespace InmobiliariasHomeCo.Concret.SQL.Cities
{
    class DataAccessCitySQL : IDataAccessCity
    {
        public City1[] GetCities()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM City";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                List<City1> cities = null;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    cities = new List<City1>();
                    while (dr.Read())
                    {
                        City1 city = new City1()
                        {
                            IdCity = int.Parse(dr["Id_City"].ToString()),
                            Name = dr["CityName"].ToString()
                        };

                        cities.Add(city);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return cities.ToArray();
            }
        }
    }
}
