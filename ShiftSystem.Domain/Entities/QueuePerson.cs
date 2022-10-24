using ShiftSystem.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Domain.Entities
{
    public class QueuePerson : BaseEntity
    {
        public int QueueId { get; set; }
        public int PersonId { get; set; }
        public Status Status { get; set; }
        public DateTime Created { get; set; }
        [ForeignKey("QueueId")]
        public virtual Queue Queue { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }
    }
}
