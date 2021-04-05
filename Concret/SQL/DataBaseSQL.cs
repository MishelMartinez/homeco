using System;
using InmobiliariasHomeCo.Abstract;
using InmobiliariasHomeCo.Abstract.Catalogs;
using InmobiliariasHomeCo.Abstract.Utilities;
using InmobiliariasHomeCo.Concret.SQL.Clients;
using InmobiliariasHomeCo.Concret.SQL.Estates;
using InmobiliariasHomeCo.Concret.SQL.Cities;
using InmobiliariasHomeCo.Concret.SQL.Colonies;
using InmobiliariasHomeCo.Concret.SQL.Owners;
using InmobiliariasHomeCo.Concret.Mock.Properties;
using InmobiliariasHomeCo.Abstract.Properties;
using InmobiliariasHomeCo.Abstract.Searchs;
using InmobiliariasHomeCo.Concret.SQL.Searchs;
using InmobiliariasHomeCo.Abstract.Grid.Consultas;
using InmobiliariasHomeCo.Abstract.DataSheets;
using InmobiliariasHomeCo.Abstract.Security;
using InmobiliariasHomeCo.Concret.SQL.Security;
using InmobiliariasHomeCo.Concret.SQL.Role;
using InmobiliariasHomeCo.Abstract.Users;
using InmobiliariasHomeCo.Abstract.Roles;
using InmobiliariasHomeCo.Abstract.Modules;
using InmobiliariasHomeCo.Concret.SQL.Users;
using InmobiliariasHomeCo.Concret.SQL.Modules;

namespace InmobiliariasHomeCo.Concret.SQL
{
    public class DataBaseSQL : IDataAccess
    {
        public IDataAccessPerson DataAccessPerson 
        {
            get
            {
                return new DataAccessClientSQL();
            }
        }

        public IDataAccessEstate DataAccessEstate
        {
            get
            {
                return new DataAccessEstateSQL();
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
                return new DataAccessPropertySQL();
            }
        }

        public IDataAccessPropertyType DataAccessSearch
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessGrid DataAccessGrid
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessPropertyType DataAccessPropertyType
        {
            get
            {
                return new DataAccessPropertyTypeSQL();
            }
        }

        public IDataAccessTypeOfOperation DataAccessTypeOfOperation
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessState DataAccessState
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessMunicipality DataAccessMunicipality
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessZone DataAccessZone
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessColonies DataAccesColonies
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IDataAccessDataSheet DataAccesDataSheet
        {
            get
            {
                throw new NotImplementedException();
            }
        }
        //
        public IDataAccessSecurity DataAccessSecurity
        {
            get
            {
                return new DataAccessSecuritySQL();
            }
        }

        public IDataAccessRole DataAccessRole
        {
            get
            {
                return new DataAccessRoleSQL();
            }

        }

        public IDataAccessUsers DataAccessUsers
        {
            get
            {
                return  new DataAccessUsers();
            }
        }

        IDataAccessRole IDataAccess.DataAccessRole
        {
            get
            {
                return new DataAccessRoleSQL();
            }
        }

        public IDataAccessModules DataAccessModules
        {
            get
            {
                return new DataAccessModulesSQL();
            }
        }
    }
}
