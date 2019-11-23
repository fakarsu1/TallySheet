using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Data.Mapping
{
    public class EmployeeMapping : EntityTypeConfiguration<Employee>
    {
        public EmployeeMapping()
        {
            this.HasOptional(t => t.Manager).WithMany(t => t.Employees).HasForeignKey(t => t.ReportTo);
            this.HasRequired(t => t.EmployeeTitle).WithMany(t => t.Employees).HasForeignKey(t => t.EmployeeTitleID);
            this.HasRequired(t => t.SalaryType).WithMany(t => t.Employees).HasForeignKey(t => t.SalaryTypeID);
            this.Property(t => t.FName).HasMaxLength(30).IsRequired();
            this.Property(t => t.LName).HasMaxLength(30).IsRequired();
            this.Property(t => t.TC).HasMaxLength(11);
            this.Property(t => t.Phone).HasMaxLength(13);
            this.Property(t => t.Email).HasMaxLength(50);
            this.Property(t => t.Adress).HasMaxLength(400);
        }
    }
}
