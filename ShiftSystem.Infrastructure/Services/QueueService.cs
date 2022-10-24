using AutoMapper;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Infrastructure.Services
{
    public class QueueService : BaseCrudService<Domain.Entities.Queue>, IQueueService
    {
        public QueueService(IShiftSystemDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
    }
}
