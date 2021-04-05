using System;
using InmobiliariasHomeCo.Abstract.Catalogs;
using InmobiliariasHomeCo.Abstract.Properties;
using InmobiliariasHomeCo.Abstract.Utilities;
using InmobiliariasHomeCo.Abstract.Searchs;
using InmobiliariasHomeCo.Abstract.Grid.Consultas;
using InmobiliariasHomeCo.Abstract.DataSheets;
using InmobiliariasHomeCo.Abstract.Security;
using InmobiliariasHomeCo.Abstract.Roles;
using InmobiliariasHomeCo.Abstract.Users;
using InmobiliariasHomeCo.Abstract.Modules;
using InmobiliariasHomeCo.Abstract.Polls;
using InmobiliariasHomeCo.Abstract.Clients;
using InmobiliariasHomeCo.Abstract.Email;

namespace InmobiliariasHomeCo.Abstract
{
    public interface IDataAccess
    {

        IDataAccessSecurity DataAccessSecurity { get; }
        IDataAccessPerson DataAccessPerson { get; }
        IDataAccessEstate DataAccessEstate { get; }
        IDataAccessCity DataAccessCity { get; }
        IDataAccessColony DataAccessColony { get; }
        IDataAccessOwner DataAccessOwner { get; }
        IDataAccessProperty DataAccessProperty { get; }
        IDataAccessPropertyType DataAccessPropertyType { get; }
        IDataAccessGrid DataAccessGrid { get; }
        IDataAccessTypeOfOperation DataAccessTypeOfOperation { get; }
        IDataAccessState DataAccessState { get; }
        IDataAccessMunicipality DataAccessMunicipality { get; }
        IDataAccessZone DataAccessZone { get; }
        IDataAccessColonies DataAccesColonies { get; }
        IDataAccessDataSheet DataAccesDataSheet { get; }


        // Role
        IDataAccessRole DataAccessRole { get; }

        //Client

        IDataAccessUsers DataAccessUsers { get; }

        IDataAccessModules DataAccessModules { get; }


        IDataAccessPolls DataAccessPolls { get; }

        IDataAccessClient DataAccessClient { get; }
        //EMAIL

        IDataAccessEmail  DataAccessEmail { get; }

    }
}
