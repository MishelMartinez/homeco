using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OKYSoft.Net.WebSocket;
using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Security;
using InmobiliariasHomeCo.Entities.Pojos.Clients;

namespace InmobiliariasHomeCo.Protocols.Clients
{
    public class REGISTERCLIENT : JsonSubCommand<ClientsMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, ClientsMessage commandInfo)
        {
            

            ClientsMessage clientsMessage = commandInfo;
            if (commandInfo.Name != null)
            {

                clientsMessage.IdUser =  App.DataAccess.DataAccessClient.RegisterParametersInterest(clientsMessage);
                if(clientsMessage.IdUser > 0)
                {
                    clientsMessage.StatuskeyInterest = App.DataAccess.DataAccessClient.RegisterkeyInterest(clientsMessage);
                    clientsMessage.StatuskeyShopping = App.DataAccess.DataAccessClient.RegisterkeyShopping(clientsMessage);

                   
                }
                else
                {
                    session.Send(("Error RegisterClient"));
                }

            }
            else
            {
                session.Send(("Error Client"));
            }
            
 
           
        }
    }
}
