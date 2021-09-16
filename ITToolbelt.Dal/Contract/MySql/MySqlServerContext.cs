using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace ITToolbelt.Dal.Contract.MySql
{
   // [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class MySqlServerContext : DbContext
    {
        public MySqlServerContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}