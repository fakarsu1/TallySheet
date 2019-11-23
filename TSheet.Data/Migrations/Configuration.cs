namespace TSheet.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TSheet.Core.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<TSheet.Data.TSheetDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TSheet.Data.TSheetDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.SalaryTypes.AddOrUpdate(t => new { t.Name }, new SalaryType { Name = "Günlük" }, new SalaryType { Name = "Aylýk" });
            context.EmployeeTitles.AddOrUpdate(t => new { t.Name }, new EmployeeTitle { Name = "Çalýþan" });
            context.WorkingLocations.AddOrUpdate(t => new { t.Name }, new WorkingLocation { Name = "Belirtilmedi" });

            base.Seed(context);

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
