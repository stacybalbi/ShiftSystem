using AutoMapper;
using ShiftSystem.Application.Generic.Handlers;
using ShiftSystem.Application.Generic.Interfaces;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Application.Person.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Person.Handlers
{
    public interface IPersonHandler : IBaseCrudHandler<PersonDto, Domain.Entities.Person>
    {
        new Task<PersonDto> GetById(int id);
        new Task<PersonDto> Update(PersonDto dto);
        new Task<PersonDto> Update(int id, PersonDto dto);
        new Task<PersonDto> Create(PersonDto dto);
        new Task<List<PersonDto>> Get(int top);
    }
    public class PersonHandler : BaseCrudHandler<PersonDto, Domain.Entities.Person>, IPersonHandler
    {
        public PersonHandler(IPersonService crudService, IMapper mapper) : base(crudService, mapper)
        {
        }

        public new async Task<PersonDto> GetById(int id)
        {
            return await base.GetById(id);
        }

        public new async Task<PersonDto> Update(PersonDto dto)
        {
            return await base.Update(dto);
        }

        public new async Task<PersonDto> Update(int id, PersonDto dto)
        {
            return await base.Update(id, dto);
        }

        public new async Task<PersonDto> Create(PersonDto dto)
        {
            return await base.Create(dto);
        }

        public async Task<List<PersonDto>> Get(int top)
        {
            return await base.Get(top);
        }
    }
}
