using System;
using System.Configuration;
using System.Data.Entity;
using ITToolbelt.Entity.Db;

namespace ITToolbelt.Dal.Contract.MsSql
{
    public class ItToolbeltContext : DbContext
    {
        protected ItToolbeltContext()
        {
        }

        public ItToolbeltContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public DbSet<Connection> Connections { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public new bool SaveChanges()
        {
            try
            {
                return base.SaveChanges() >= 0;
            }
            catch (Exception e)
            {
#if DEBUG
                throw e;
#else
                return false;
#endif

            }
        }
    }
}