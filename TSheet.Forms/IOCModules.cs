using Ninject.Modules;
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
using TSheet.Services.Concrete;

namespace TSheet.Forms
{
    public class IOCModules : NinjectModule
    {
        public override void Load()
        {

            Bind<DbContext>().To<TSheetDbContext>().InSingletonScope();
            Bind<IUnitOfWork>().To<EFUnitOfWork>();

            Bind<IRepository<Employee>>().To<Repository<Employee>>();
            Bind<IRepository<EmployeeTitle>>().To<Repository<EmployeeTitle>>();
            Bind<IRepository<SalaryType>>().To<Repository<SalaryType>>();
            Bind<IRepository<WorkingLocation>>().To<Repository<WorkingLocation>>();
            Bind<IRepository<WorkingTime>>().To<Repository<WorkingTime>>();

            Bind<IEmployeeService>().To<EmployeeService>();
            Bind<IEmployeeTitleService>().To<EmployeeTitleService>();
            Bind<ISalaryTypeService>().To<SalaryTypeService>();
            Bind<IWorkingLocationService>().To<WorkingLocationService>();
            Bind<IWorkingTimeService>().To<WorkingTimeService>();
        }
    }
}
