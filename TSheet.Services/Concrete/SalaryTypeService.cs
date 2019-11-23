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
    public class SalaryTypeService : ISalaryTypeService
    {
        IUnitOfWork _unitOfWork;
        IRepository<SalaryType> _salaryRepo;
        public SalaryTypeService(IUnitOfWork unitOfWork, IRepository<SalaryType> repository)
        {
            _unitOfWork = unitOfWork;
            _salaryRepo = repository;
        }
        public IList<SalaryType> Get()
        {
            return _salaryRepo.Get().ToList();
        }
    }
}
