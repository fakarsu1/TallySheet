using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Data.Mapping
{
    public class EmployeeTitleMapping : EntityTypeConfiguration<EmployeeTitle>
    {
        public EmployeeTitleMapping()
        {
            Property(t => t.Name).HasMaxLength(40);
        }
    }
}
