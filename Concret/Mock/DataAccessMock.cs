using InmobiliariasHomeCo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InmobiliariasHomeCo.Abstract.Catalogs;
using InmobiliariasHomeCo.Abstract.Utilities;
using InmobiliariasHomeCo.Concret.Mock.Client;
using InmobiliariasHomeCo.Concret.Mock.Estates;
using InmobiliariasHomeCo.Concret.SQL.Cities;
using InmobiliariasHomeCo.Concret.SQL.Colonies;
using InmobiliariasHomeCo.Concret.SQL.Owners;
using InmobiliariasHomeCo.Concret.Mock.Properties;
using InmobiliariasHomeCo.Abstract.Properties;
using InmobiliariasHomeCo.Abstract.Searchs;
using InmobiliariasHomeCo.Concret.Mock.Searchs;
using InmobiliariasHomeCo.Abstract.Grid.Consultas;
using InmobiliariasHomeCo.Concret.Mock.Grid.Consultas;
using InmobiliariasHomeCo.Concret.Mock.Search;
using InmobiliariasHomeCo.Abstract.DataSheets;
using InmobiliariasHomeCo.Concret.Mock.DataSheets;
using InmobiliariasHomeCo.Abstract.Security;

using InmobiliariasHomeCo.Abstract.Users;
using InmobiliariasHomeCo.Abstract.Roles;
using InmobiliariasHomeCo.Abstract.Modules;

namespace InmobiliariasHomeCo.Concret.Mock
{
    public class DataAccessMock : IDataAccess
    {
        public IDataAccessPerson DataAccessPerson
        {
            get
            {
                return new DataAccessClientMock();
            }
        }

        public IDataAccessEstate DataAccessEstate
        {
            get
            {
                return new DataAccessEstateMock();
            }
        }

        public IDataAccessCity DataAccessCity
        {
            get
            {
                return new DataAccessCitySQL();
            }
        }

        public IDataAccessColony DataAccessColony
        {
            get
            {
                return new DataAccessColonySQL();
            }
        }

        public IDataAccessOwner DataAccessOwner
        {
            get
            {
                return new DataAccessOwnerSQL();
            }
        }

        public IDataAccessProperty DataAccessProperty
        {
            get
            {
                return new DataAccessPropertyMock();
            }
        }

        public IDataAccessPropertyType DataAccessPropertyType
        {
            get
            {
                return new DataAccessPropertyTypeMock();
            }
        }

        public IDataAccessGrid DataAccessGrid
        {
            get
            {
                return new DataAccessGridConsultasMock();
            }
        }

        public IDataAccessTypeOfOperation DataAccessTypeOfOperation
        {
            get
            {
                return new DataAccessTypeOfOperationMock();
            }
        }

        public IDataAccessState DataAccessState
        {
            get
            {
                return new DataAccessStateMock();
            }
        }

        public IDataAccessMunicipality DataAccessMunicipality
        {
            get
            {
                return new DataAccessMunicipalityMock();
            }
        }

        public IDataAccessZone DataAccessZone
        {
            get
            {
                return new DataAccessZoneMock();
            }
        }

        public IDataAccessColonies DataAccesColonies
        {
            get
            {
                return new DataAccessColoniesMock();
            }
        }

        public IDataAccessDataSheet DataAccesDataSheet
        {
            get
            {
                return new DataAccessDataSheetMock();
            }
        }

        public IDataAccessSecurity DataAccessSecurity
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessRole DataAccessRole
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessUsers DataAccessUsers
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IDataAccessRole IDataAccess.DataAccessRole
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessModules DataAccessModules
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
