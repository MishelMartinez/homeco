using InmobiliariasHomeCo.Entities.Pojos.Properties;
using OKYSoft.Net.WebSocket;
using OKYSoft.Net.WebSocket.SubProtocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InmobiliariasHomeCo.Protocols.HCProperty
{
    public class UPDATEPROPERTYIMAGES : JsonSubCommand<PropertyMessage>
    {
        protected override void ExecuteJsonCommand(WebSocketSession session, PropertyMessage commandInfo)
        {
            Console.WriteLine("Protocolo alcanzado");
            WebSocketServerTest server = session.AppServer as WebSocketServerTest;

            session.Send(String.Format("{0}", App.DataAccess.DataAccessProperty.UpdatePropertyImages(
                        string.Concat(commandInfo.MimeType      ),
                        string.Concat(commandInfo.Principal     ),
                        string.Concat(commandInfo.Description   ),
                        string.Concat(commandInfo.Url           ),
                            int.Parse(commandInfo.Id_Property   ),
                        string.Concat(commandInfo.MimeType1     ),
                        string.Concat(commandInfo.Principal1    ),
                        string.Concat(commandInfo.Description1  ),
                        string.Concat(commandInfo.Url1          ),
                        string.Concat(commandInfo.MimeType2     ),
                        string.Concat(commandInfo.Principal2    ),
                        string.Concat(commandInfo.Description2  ),
                        string.Concat(commandInfo.Url2          ),
                        string.Concat(commandInfo.MimeType3     ),
                        string.Concat(commandInfo.Principal3    ),
                        string.Concat(commandInfo.Description3  ),
                        string.Concat(commandInfo.Url3          )
                )));
        }
    }
}
