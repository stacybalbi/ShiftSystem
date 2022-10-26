using AutoMapper;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Application.QueuePerson.Dto;
using ShiftSystem.Domain.Entities;
using ShiftSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Infrastructure.Services
{
    public class QueuePersonService : BaseCrudService<QueuePerson>, IQueuePersonService
    {
        private readonly IMapper _mapper;
        public IShiftSystemDbContext _dbContext;
        public QueuePersonService(IShiftSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }


        public Task Push(int queueId)
        {
            _dbContext.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task Put(QueuePersonDto dto)
        {
            //var queue = _dbSet.Where(QueuePerson => QueuePerson.QueueId == dto.QueueId && QueuePerson.Status != Domain.Enums.Status.Inactive)
            //                                   .OrderBy(QueuePerson => QueuePerson.Created).ToList();

            //if (queue.Any(x => x.PersonId == dto.PersonId))
            //    throw new Exception("No se puede agregar la persona a la fila más de una vez.");

            //QueuePersonDto entity = new QueuePersonDto
            //{
            //    Created = DateTime.Now,
            //    PersonId = dto.PersonId,
            //    QueueId = dto.QueueId,
            //    Status = Domain.Enums.Status.OnStandby
            //};

            await _dbSet.AddAsync(_mapper.Map<QueuePerson>(dto));
            _dbContext.SaveChanges();
        }

        public void Put(int queueId)
        {
        }
    }
}
