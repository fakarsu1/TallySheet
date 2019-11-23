using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Services.Abstract
{
    public interface IWorkingTimeService
    {

        int Add(WorkingTime workingTime);

        List<WorkingTime> Get();

        int Remove(WorkingTime workingTime);

        int Update(WorkingTime workingTime);

        string AddRange(IList<WorkingTime> workingTimes);

        List<WorkingTime> GetMonthlyWorkingTime(Employee employee, int month, int year);
    }
}
