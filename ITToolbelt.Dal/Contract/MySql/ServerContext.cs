using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace ITToolbelt.Dal.Contract.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ServerContext : DbContext
    {
        public ServerContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}