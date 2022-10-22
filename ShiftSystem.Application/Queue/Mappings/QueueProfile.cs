using AutoMapper;
using ShiftSystem.Application.Person.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Queue.Mappings
{
    public class QueueProfile : Profile
    {
       public QueueProfile(){CreateMap<Domain.Entities.Person, PersonDto>();}
    }
}
