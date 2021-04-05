using InmobiliariasHomeCo.Abstract.Email;
using InmobiliariasHomeCo.Entities.Pojos.SendEmail;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Concret.SQL.Email
{
    public class DataAccessEmail : IDataAccessEmail
    {
        public InformationRequestMessage SendInformationSalesBussines(InformationRequestMessage information)
        {
            InformationRequestMessage informationRequestMessage = new InformationRequestMessage();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {
                connection.Open();
                string query = "sp_SendInformationSalesBussines";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@IdProperty", information.IdProperty));
                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                        informationRequestMessage = new InformationRequestMessage()
                        {

                           
                            NameBussinesPartner = dr["NameBussinesPartner"].ToString(),
                            EmailBussinesPartner = dr["Email"].ToString()


                        };

                    return informationRequestMessage;
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
