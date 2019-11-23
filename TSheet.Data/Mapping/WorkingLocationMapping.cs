using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Data.Mapping
{
    public class WorkingLocationMapping : EntityTypeConfiguration<WorkingLocation>
    {
        public WorkingLocationMapping()
        {
            Property(t => t.Name).HasMaxLength(60);

        }
    }
}
