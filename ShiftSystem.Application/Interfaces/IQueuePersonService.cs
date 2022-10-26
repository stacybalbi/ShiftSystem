using ShiftSystem.Application.Generic.Interfaces;
using ShiftSystem.Application.QueuePerson.Dto;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Interfaces
{
    public interface IQueuePersonService : IBaseCrudService<Domain.Entities.QueuePerson>
    {
        Task Put(QueuePersonDto dto);
        Task Push(int queueId);
        void Put(int queueId);

    }
}
