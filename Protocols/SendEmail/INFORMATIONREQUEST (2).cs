using InmobiliariasHomeCo.Entities.Pojos.Properties;
using InmobiliariasHomeCo.Entities.Pojos.SendEmail;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.SendEmail;
using Newtonsoft.Json;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.SendEmail
{
    public class INFORMATIONREQUEST : JsonSubCommand<InformationRequestMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, InformationRequestMessage commandInfo)
        {
            Console.WriteLine("Protocolo Alcanzado INFORMATIONREQUEST");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            InformationRequestMessage informationRequest = App.DataAccess.DataAccessEmail.SendInformationSalesBussines(commandInfo);

            SendFunction(informationRequest);

        }

        private void  SendFunction(InformationRequestMessage information )
        {
            string url = "xzx";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            Stream stream = req.GetRequestStream();

            string json = JsonConvert.SerializeObject(information); ;
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            stream.Write(buffer, 0, buffer.Length);
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();

            if (res.StatusCode == HttpStatusCode.OK)
            {
                string content;

                using (StreamReader streamReader = new StreamReader(res.GetResponseStream()))
                {
                    content = streamReader.ReadToEnd();
                }

                Console.WriteLine(content);
                Console.ReadLine();

            }

            
        }

    }
}
