using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSheet.Core.Domain
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            Employees = new HashSet<Employee>();
            WorkingTimes = new HashSet<WorkingTime>();
        }
        public string FName { get; set; }
        public string LName { get; set; }
        public int EmployeeTitleID { get; set; }
        public string TC { get; set; }
        public DateTime HireDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
        public int? ReportTo { get; set; }
        public decimal Salary { get; set; }
        public int SalaryTypeID { get; set; }

        public Employee Manager { get; set; }
        public ICollection<Employee> Employees { get; set; }
        public SalaryType SalaryType { get; set; }
        public ICollection<WorkingTime> WorkingTimes { get; set; }
        public EmployeeTitle EmployeeTitle { get; set; }

        public override string ToString()
        {
            return $"{ID} - {FName} {LName}";
        }
        public override bool Equals(Object obj)
        {
            var item = obj as Employee;
            if (item == null)
            {
                return false;
            }
            return this.ID.Equals(item.ID);
        }
        public override int GetHashCode()
        {
            return this.ID.GetHashCode();
        }

        public string GetFullName()
        {
            return $"{FName} {LName}";
        }
    }
}
