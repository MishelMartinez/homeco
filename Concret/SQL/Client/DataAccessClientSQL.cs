using System;
using InmobiliariasHomeCo.Abstract.Catalogs;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using InmobiliariasHomeCo.Entities.Validations.MaritalStatus;
using InmobiliariasHomeCo.Entities.Persons;
using InmobiliariasHomeCo.Entities;

namespace InmobiliariasHomeCo.Concret.SQL.Clients
{
    public class DataAccessClientSQL : IDataAccessPerson
    {
        public Person InsertPerson(Person person)
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                Client client = person as Client;

                if (client != null)
                {
                    connection.Open();

                    string query = "INSERT INTO Client (Parent,PhoneNumber,MovilNumber,Email,RegDate,BirthDate,MaritalStatus,Gender,NumChildren) " +
                                   "VALUES " +
                                   "(@Parent,@PhoneNumber,@MovilNumber,@Email,@RegDate,@BirthDate,@MaritalStatus,@Gender,@NumChildren); " +
                                   "SELECT @@IDENTITY";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.CommandType = CommandType.Text;


                    command.Parameters.Add("@Parent", SqlDbType.VarChar, 50).Value = client.Name;
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
                }
            }
            return null;
        }

        public Person[] GetPersons()
        {
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Customer";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.Text;

                List<Client> clientes = null;

                try
                {
                    SqlDataReader dr = command.ExecuteReader();
                    clientes = new List<Client>();
                    while (dr.Read())
                    {
                        Client cliente = new Client()
                        {
                            Name = dr["Parent"].ToString(),
                            PhoneNumber = dr["PhoneNumber"].ToString(),
                            MobilNumber = dr["MovilNumber"].ToString(),
                            Email = dr["Email"].ToString(),
                            RegDate = DateTime.Parse(dr["RegDate"].ToString()),
                            BirthDate = DateTime.Parse(dr["BirthDate"].ToString()),
                            MaritalStatus = (MaritalStatus)Enum.Parse(typeof(MaritalStatus),dr["MaritalStatus"].ToString()),
                            Gender = new Gender(){
                                Description = dr["Gender"].ToString()
                            },
                            ChildrenNUmber = int.Parse(dr["NumChildren"].ToString())

                        };

                        clientes.Add(cliente);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
                
                return clientes.ToArray();

            }
        }
    }
}
