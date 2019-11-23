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
    public class WorkingLocationService : IWorkingLocationService
    {
        IUnitOfWork _unitOfWork;
        IRepository<WorkingLocation> _repository;
        public WorkingLocationService(IUnitOfWork unitOfWork, IRepository<WorkingLocation> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }
        public int Add(WorkingLocation workingLocation)
        {
            _repository.Add(workingLocation);
            return _unitOfWork.SaveChanges();
        }

        public IList<WorkingLocation> Get()
        {
            return _repository.Get().ToList();
        }

        public int Remove(WorkingLocation workingLocation)
        {
            _repository.Remove(workingLocation);
            return _unitOfWork.SaveChanges();
        }
    }
}
