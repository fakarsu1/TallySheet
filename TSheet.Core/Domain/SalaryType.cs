using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSheet.Core.Domain
{
    public class SalaryType : BaseEntity
    {
        public SalaryType()
        {
            Employees = new HashSet<Employee>();
        }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
