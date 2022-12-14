using AutoMapper;
using ShiftSystem.Application.QueuePerson.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.QueuePerson.Mappings
{
    public class QueuePersonProfile : Profile
    {
        public QueuePersonProfile() { 

            CreateMap<Domain.Entities.QueuePerson, QueuePersonDto>();
            CreateMap<QueuePersonDto, Domain.Entities.QueuePerson>();

        }
    }
}
