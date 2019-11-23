using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Data.Mapping
{
    public class WorkingTimeMapping : EntityTypeConfiguration<WorkingTime>
    {
        public WorkingTimeMapping()
        {
            HasKey(t => new { t.WorkingLocationID, t.EmployeeID, t.WorkingDate });
        }
    }
}
