using InmobiliariasHomeCo.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo
{
    public class Service1:ServiceBase
    {
        private WebSocketServerTest server;

        public Service1()         {             this.server = new WebSocketServerTest();             this.server.Setup(9097);         }

        protected override void OnStart(string[] args)         {             this.server.Start();         }          protected override void OnStop()         {             this.server.Stop();         }
    }
}
