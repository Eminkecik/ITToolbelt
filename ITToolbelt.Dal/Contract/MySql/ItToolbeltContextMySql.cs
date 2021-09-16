using System;
using System.Data.Entity;
using ITToolbelt.Entity.Db;
using MySql.Data.EntityFramework;

namespace ITToolbelt.Dal.Contract.MySql
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ItToolbeltContextMySql : DbContext
    {
        public ItToolbeltContextMySql()
        {
        }

        public ItToolbeltContextMySql(string nameOrConnectionString) : base(nameOrConnectionString)
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