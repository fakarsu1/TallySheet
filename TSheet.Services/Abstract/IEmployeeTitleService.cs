using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Services.Abstract
{
    public interface IEmployeeTitleService
    {
        int Add(EmployeeTitle title);

        IList<EmployeeTitle> Get();

        int Remove(EmployeeTitle title);
    }
}
