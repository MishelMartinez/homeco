using InmobiliariasHomeCo.Entities;
using InmobiliariasHomeCo.Entities.Pojos.Clients;
using InmobiliariasHomeCo.Entities.Security;
using System;

namespace InmobiliariasHomeCo.Abstract.Clients
{
    public interface IDataAccessClient
    {
        int             RegisterClient              (Client client);

        string          GetAllClients               ();

        int             RegisterParametersInterest  (ClientsMessage dates);

        Boolean         RegisterkeyShopping         (ClientsMessage dates);

        Boolean         RegisterkeyInterest         (ClientsMessage dates);



    }
}
