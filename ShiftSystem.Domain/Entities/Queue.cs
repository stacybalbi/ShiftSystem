using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Domain.Entities
{
    public class Queue : BaseEntity
    {
        public bool Deleted { get; set; }

        public Person Person { get; set; }
    }
}
