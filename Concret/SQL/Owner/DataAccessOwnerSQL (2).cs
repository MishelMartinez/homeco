using InmobiliariasHomeCo.Abstract.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using InmobiliariasHomeCo.Entities.Persons.Owners;


namespace InmobiliariasHomeCo.Concret.SQL.Owners
{
    public class DataAccessOwnerSQL : IDataAccessOwner
    {
        public Owner[] GetOwners()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Owner";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                List<Owner> owners = null;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    owners = new List<Owner>();
                    while (dr.Read())
                    {
                        Owner owner = new Owner()
                        {
                            IdOwner = int.Parse(dr["Id_Owner"].ToString()),
                            
                            Name = dr["Parent"].ToString()
                        };

                        owners.Add(owner);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                return owners.ToArray();
            }
        }

        public Owner InsertOwner(Owner owner)
        {
            throw new NotImplementedException();
        }
    }
}
