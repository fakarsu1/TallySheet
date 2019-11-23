using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSheet.Core.Domain
{
    public class WorkingTime : BaseEntity
    {
        public int EmployeeID { get; set; }
        public DateTime WorkingDate { get; set; }
        public int WorkingLocationID { get; set; }
        public int WorkingHours { get; set; }

        public Employee Employee { get; set; }
        public WorkingLocation WorkingLocation { get; set; }
    }
}
