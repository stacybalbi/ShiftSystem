using ShiftSystem.Application.Generic.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Person.Dto
{
    public class PersonUriDto : BaseDto
    {
        public string DNI { get; set; }
        public string FullName { get; set; }
        public Uri FileUri { get; set; }
        public int Age { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
    }
}
