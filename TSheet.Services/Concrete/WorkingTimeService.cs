using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;
using TSheet.Data;
using TSheet.Data.Repository;
using TSheet.Data.UnitOfWork;
using TSheet.Services.Abstract;

namespace TSheet.Services.Concrete
{
    public class WorkingTimeService : IWorkingTimeService
    {
        IUnitOfWork _unitOfWork;
        IRepository<WorkingTime> _wtRepository;

        public WorkingTimeService(IUnitOfWork unitOfWork, IRepository<WorkingTime> repository)
        {
            
            _unitOfWork = unitOfWork;
            _wtRepository = repository;

        }
        public int Add(WorkingTime workingTime)
        {
            _wtRepository.Add(workingTime);
            return _unitOfWork.SaveChanges();
        }

        public List<WorkingTime> Get()
        {
            return _wtRepository.Get().ToList();
        }

        public int Remove(WorkingTime workingTime)
        {
            _wtRepository.Remove(workingTime);
            return _unitOfWork.SaveChanges();
        }

        public int Update(WorkingTime workingTime)
        {
            _wtRepository.Update(workingTime);
            return _unitOfWork.SaveChanges();
        }
        public string AddRange(IList<WorkingTime> workingTimes)
        {
            foreach (WorkingTime item in workingTimes)
            {
                _wtRepository.Add(item);
            }
            return _unitOfWork.SaveChangesTransactional();
        }

        public List<WorkingTime> GetMonthlyWorkingTime(Employee employee, int month, int year)
        {
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
            var result = _wtRepository.Get(t => t.EmployeeID == employee.ID && startDate <= t.WorkingDate && t.WorkingDate <= endDate).OrderBy(t => t.WorkingDate).ThenBy(t => t.EmployeeID).ToList();
            return result;
        }
    }
}
