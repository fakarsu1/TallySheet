using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Services.Abstract
{
    public interface IEmployeeService
    {
        int Add(Employee employee);

        IList<Employee> Get();

        int Remove(Employee employee);

        int Update(Employee employee);
    }
}
