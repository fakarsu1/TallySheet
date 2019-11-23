using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;
using TSheet.Data.Mapping;

namespace TSheet.Data
{
    public class TSheetDbContext : DbContext
    {
        public TSheetDbContext() : base("name=TSheet")
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalaryType> SalaryTypes { get; set; }
        public DbSet<WorkingLocation> WorkingLocations { get; set; }
        public DbSet<WorkingTime> WorkingTimes { get; set; }
        public DbSet<EmployeeTitle> EmployeeTitles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new EmployeeMapping());
            modelBuilder.Configurations.Add(new WorkingLocationMapping());
            modelBuilder.Configurations.Add(new WorkingTimeMapping());
            modelBuilder.Configurations.Add(new EmployeeTitleMapping());
            modelBuilder.Configurations.Add(new SalaryTypeMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
