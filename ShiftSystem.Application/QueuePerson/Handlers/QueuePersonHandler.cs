using AutoMapper;
using ShiftSystem.Application.Generic.Handlers;
using ShiftSystem.Application.Generic.Interfaces;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Application.QueuePerson.Dto;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.QueuePerson.Handlers
{
    public interface IQueuePersonHandler : IBaseCrudHandler<QueuePersonDto, Domain.Entities.QueuePerson>
    {
        new Task<QueuePersonDto> GetById(int id);
        new Task<QueuePersonDto> Update(QueuePersonDto dto);
        new Task<QueuePersonDto> Update(int id, QueuePersonDto dto);
        new Task<QueuePersonDto> Create(QueuePersonDto dto);
        Task<List<QueuePersonDto>> GetByQueueId(int queueId);
        Task Put (QueuePersonDto dto);
        Task Push(int queueId);
    }


    public class QueuePersonHandler : BaseCrudHandler<QueuePersonDto, Domain.Entities.QueuePerson>, IQueuePersonHandler
    {
        private readonly IQueuePersonService _crudService;
        public QueuePersonHandler(IQueuePersonService crudService, IMapper mapper) : base(crudService, mapper)
        {
            _crudService = crudService;
        }

        public new async Task<QueuePersonDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<QueuePersonDto> Update(QueuePersonDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<QueuePersonDto> Update(int id, QueuePersonDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<QueuePersonDto> Create(QueuePersonDto dto)
        {
            return await base.Create(dto);
        }

        public async Task<List<QueuePersonDto>> GetByQueueId(int queueId)
        {
            return _crudService.GetByQueueId(queueId);
        }

        public async Task Put(QueuePersonDto dto)
        {
            await _crudService.Put(dto);
        }

        public async Task Push(int queueId)
        {
            await _crudService.Push(queueId);

        }
    }



}
