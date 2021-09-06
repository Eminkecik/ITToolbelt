using System.Data.Entity;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class ServerContext : DbContext
    {
        public ServerContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
    }
}