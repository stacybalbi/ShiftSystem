using ShiftSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Domain.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public int Cedula { get; set; }


    }
}
