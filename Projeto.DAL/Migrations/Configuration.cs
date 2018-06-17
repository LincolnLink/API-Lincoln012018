namespace Projeto.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Projeto.DAL.Context.DataContext>
    {
        public Configuration()
        {
            //permiss�o de CREATE ou ALTER no banco de dados
            AutomaticMigrationsEnabled = true;

            //permiss�o de DROP..
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Projeto.DAL.Context.DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            //  context.People.AddOrUpdate(
            // p => p.FullName,
            // new Person { FullName = "Andrew Peters" },
            // new Person { FullName = "Brice Lambson" },
            // new Person { FullName = "Rowan Miller" }
            // );
        }
    }
}
