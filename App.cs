using System;
using InmobiliariasHomeCo.Abstract;
using InmobiliariasHomeCo.Concret.SQL;
using System.Configuration;
using InmobiliariasHomeCo.Concret.Mock;

namespace InmobiliariasHomeCo
{
    public class App
    {
        private static IDataAccess dataAccess;
        public static IDataAccess DataAccess
        {
            /*
            get 
            {
                if(App.dataAccess== null)
                {
                    App.dataAccess = new DataAccessMock();
                }
                return App.dataAccess;
            }
            */

            
            get
            {
                if (App.dataAccess == null)
                {
                    App.dataAccess = new DataBaseSQL();
                }
                return App.dataAccess;
            }
            
        }
        private static string connectionString;
        public static string ConnectionString
        {
            get
            {
                if (App.connectionString == null)
                    App.connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];

                return App.connectionString;
            }


        }



    }
}
