using ITToolbelt.Dal.Abstract;
using ITToolbelt.Dal.Contract.MsSql;
using ITToolbelt.Entity.EntityClass;
using ITToolbelt.Entity.Enum;
using Ninject;
using Ninject.Modules;

namespace ITToolbelt.Bll.ExternalLibraries
{
    public class NinjectModules : NinjectModule
    {
        private string ConnectionSting { get; }
        private DbServerType DatabaseType;

        public NinjectModules(ConnectInfo connectInfo)
        {
            ConnectionSting = connectInfo.ConnectionString;
            DatabaseType = connectInfo.DatabaseType;
            StandartKernel = new StandardKernel();
            Load();
        }

        public IKernel StandartKernel { get; set; }
        public sealed override void Load()
        {
            switch (DatabaseType)
            {
                case DbServerType.MsSql:
                    LoadMsSql();
                    break;
                case DbServerType.MySql:
                    LoadMySql();
                    break;
                default:
                    break;
            }
        }

        private void LoadMsSql()
        {
            StandartKernel.Bind<IConnectionDal>().To<MsSqlConnectionDal>().WithConstructorArgument("connectionString", ConnectionSting);
        }
        private void LoadMySql()
        {
            StandartKernel.Bind<IDepartmentDal>().To<MySqlDepartmentDal>().WithConstructorArgument("connectionString", ConnectionSting);
        }
    }
}