namespace ITToolbelt.Dal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class MsSqlConfiguration : DbMigrationsConfiguration<ITToolbelt.Dal.Contract.MsSql.ItToolbeltContext>
    {
        public MsSqlConfiguration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ITToolbelt.Dal.Contract.MsSql.ItToolbeltContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
