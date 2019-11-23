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
    public class EmployeeTitleService : IEmployeeTitleService
    {
        IUnitOfWork _unitOfWork;
        IRepository<EmployeeTitle> _repository;
        public EmployeeTitleService(IUnitOfWork unitOfWork, IRepository<EmployeeTitle> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;

        }
        public int Add(EmployeeTitle title)
        {
            _repository.Add(title);
           return _unitOfWork.SaveChanges();
        }

        public IList<EmployeeTitle> Get()
        {
            return _repository.Get().ToList();
        }

        public int Remove(EmployeeTitle title)
        {
            _repository.Remove(title);
            return _unitOfWork.SaveChanges();
        }
    }
}
