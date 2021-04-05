using System;
using InmobiliariasHomeCo.Protocols;
using System.ServiceProcess;

namespace InmobiliariasHomeCo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //PropertyType[] searchs = App.DataAccess.DataAccessPropertyType.GetPropertyType();
            //for (int i = 0; i < searchs.Length; i++)
            //{

            //}


           
            WebSocketServerTest server = new WebSocketServerTest();
            server.Setup(9097);
            Console.WriteLine("Server HomeCo Listener .......");
            server.Start();
            Console.ReadLine();
            server.Stop();
            Console.WriteLine("Error");
            

            //ServiceBase.Run(new Service1());
        }
    }
}