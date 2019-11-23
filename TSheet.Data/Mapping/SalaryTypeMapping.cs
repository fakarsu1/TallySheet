using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Data.Mapping
{
    public class SalaryTypeMapping : EntityTypeConfiguration<SalaryType>
    {
        public SalaryTypeMapping()
        {
            this.Property(t => t.Name).HasMaxLength(50);
        }
    }

}
