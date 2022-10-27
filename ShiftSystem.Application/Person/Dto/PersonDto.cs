using ShiftSystem.Application.Generic.Dto;
using ShiftSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Person.Dto
{
    public class PersonDto : BaseDto
    {
        public Uri fileUri { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }

    }
}
