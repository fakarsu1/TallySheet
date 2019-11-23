using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSheet.Core.Domain;

namespace TSheet.Services.Abstract
{
    public interface ISalaryTypeService
    {
        IList<SalaryType> Get();
    }
}
