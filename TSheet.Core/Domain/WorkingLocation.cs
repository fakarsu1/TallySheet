using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSheet.Core.Domain
{
    public class WorkingLocation : BaseEntity
    {
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
