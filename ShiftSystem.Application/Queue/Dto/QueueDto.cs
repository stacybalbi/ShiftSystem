using ShiftSystem.Application.Generic.Dto;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Queue.Dto
{
    public class QueueDto : BaseDto
    {
        public Domain.Entities.Person Person { get; set; }
    }
}
