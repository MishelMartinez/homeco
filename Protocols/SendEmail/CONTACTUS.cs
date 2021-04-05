using InmobiliariasHomeCo.Entities.Pojos.SendEmail;
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
    public class CONTACTUS : JsonSubCommand<ContactUsMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, ContactUsMessage commandInfo)
        {
            ContactUsMessage contactUsMessage = commandInfo;

            string url = @"https://homecofunction.azurewebsites.net/api/HttpTriggerCSharp1?code=CICaPbyGw707TsmpRC5Z6NT2Xdi7v0Z0eRPUCV4IaBC1ZFWd6x5Vzg==";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/json";

            Stream stream = req.GetRequestStream();

            string json = JsonConvert.SerializeObject(contactUsMessage); ;
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

            }
        }
    }
}
