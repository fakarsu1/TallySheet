using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    public class EmployeeService : IEmployeeService
    {
        IRepository<Employee> _employeeRepo;
        IUnitOfWork _unitOfWork;
        public EmployeeService(IRepository<Employee> employeeRepo, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _employeeRepo = employeeRepo;
        }

        public int Add(Employee employee)
        {
            _employeeRepo.Add(employee);
            return _unitOfWork.SaveChanges();
        }
        public int Update(Employee employee)
        {
            _employeeRepo.Update(employee);
            return _unitOfWork.SaveChanges();
        }
        public int Remove(Employee employee)
        {
            _employeeRepo.Remove(employee);
            return _unitOfWork.SaveChanges();
        }

        public IList<Employee> Get()
        {
            return _employeeRepo.Get().ToList();

        }
    }
}
