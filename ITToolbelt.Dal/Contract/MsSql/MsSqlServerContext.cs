using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class MsSqlServerContext : DbContext
    {
        public MsSqlServerContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            
        }
    }
}