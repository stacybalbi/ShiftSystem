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
        public string Name { get; set; }
        public Status status { get; set; }
    }
}
