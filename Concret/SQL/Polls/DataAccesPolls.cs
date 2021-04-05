using InmobiliariasHomeCo.Abstract.Polls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Entities.Security;
using System.Data.SqlClient;
using System.Data;
using InmobiliariasHomeCo.Entities.Pojos.Poll;

namespace InmobiliariasHomeCo.Concret.SQL.Polls
{
    public class DataAccesPolls : IDataAccessPolls
    {
        public PollMessage RegisterPoll(PollMessage dates)
        {
            PollMessage datesSecurity = new PollMessage();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_RegisterSurvey";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                command.Parameters.Add(new SqlParameter("@Id_User", dates.IdUser));
                command.Parameters.Add(new SqlParameter("@Interests", dates.Interests));
                command.Parameters.Add(new SqlParameter("@Alternative", dates.Alternative));
                command.Parameters.Add(new SqlParameter("@Price", dates.Price));
                command.Parameters.Add(new SqlParameter("@Spaces", dates.Spaces));
                command.Parameters.Add(new SqlParameter("@Ubication", dates.Ubication));
                command.Parameters.Add(new SqlParameter("@StateConservation", dates.StateConservation));
                command.Parameters.Add(new SqlParameter("@BuyProperty", dates.BuyProperty));
                command.Parameters.Add(new SqlParameter("@TextBuyProperty", dates.TextBuyProperty));
                command.Parameters.Add(new SqlParameter("@Observations", dates.Observations));




                try
                {
                    SqlDataReader dr = command.ExecuteReader();

                    while (dr.Read())
                    {
                        datesSecurity = new PollMessage()
                        {
                            IdUser = int.Parse(dr["Id_User"].ToString())
                        };


                    }
                    return datesSecurity;
                }
                catch (Exception ex)
                {
                    Console.Write(ex);
                    return datesSecurity = new PollMessage() { IdUser = 0 };
                }


            }
        }

        DatesSecurity IDataAccessPolls.RegisterSurvey(DatesSecurity dates)
        {
            DatesSecurity datesSecurity = new DatesSecurity();
            using (SqlConnection connection = new SqlConnection(App.ConnectionString))
            {

                connection.Open();
                string query = "sp_RegisterSurvey";

                SqlCommand command = new SqlCommand(query, connection);
                command.CommandType = CommandType.StoredProcedure;


                /*
                command.Parameters.Add(new SqlParameter("@FullName", dates.Client.FullName));
                command.Parameters.Add(new SqlParameter("@Email", dates.Client.Email));
                command.Parameters.Add(new SqlParameter("@Phone", dates.Client.Phone));
                */
                command.Parameters.Add(new SqlParameter("@Id_User", dates.IdUser));
                command.Parameters.Add(new SqlParameter("@Interests", dates.Poll.Interests));
                command.Parameters.Add(new SqlParameter("@Alternative", dates.Poll.Alternative));
                command.Parameters.Add(new SqlParameter("@Price", dates.Poll.Price));
                command.Parameters.Add(new SqlParameter("@Spaces", dates.Poll.Spaces));
                command.Parameters.Add(new SqlParameter("@Ubication", dates.Poll.Ubication));
                command.Parameters.Add(new SqlParameter("@StateConservation", dates.Poll.StateConservation));
                command.Parameters.Add(new SqlParameter("@BuyProperty", dates.Poll.BuyProperty));
                command.Parameters.Add(new SqlParameter("@TextBuyProperty", dates.Poll.TextBuyProperty));
                command.Parameters.Add(new SqlParameter("@Observations", dates.Poll.Observations));




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
    }
}
