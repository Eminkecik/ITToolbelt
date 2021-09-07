using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class ServerContext : DbContext
    {
        public ServerContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
            
        }
    }
}