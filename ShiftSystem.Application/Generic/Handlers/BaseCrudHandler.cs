using AutoMapper;
using ShiftSystem.Application.Generic.Dto;
using ShiftSystem.Application.Generic.Interfaces;
using ShiftSystem.Application.Interfaces;
using ShiftSystem.Application.Person.Dto;
using ShiftSystem.Application.QueuePerson.Dto;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Generic.Handlers
{
    public class BaseCrudHandler<TDto, TEntity> : IBaseCrudHandler<TDto, TEntity> where TDto : BaseDto where TEntity : BaseEntity
    {
        private readonly IBaseCrudService<TEntity> _crudService;
        public readonly IMapper _mapper;
        private IPersonService crudService;
        private IMapper mapper;

        public BaseCrudHandler(IBaseCrudService<TEntity> crudService, IMapper mapper)
        {
            _crudService = crudService;
            _mapper = mapper;
        }

        public BaseCrudHandler(IPersonService crudService, IMapper mapper)
        {
            this.crudService = crudService;
            this.mapper = mapper;
        }

        public virtual async Task<TDto> Create(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _crudService.Create(entity);
            return _mapper.Map(entity, dto);
        }

        public async Task<bool> Delete(int id)
        {
            return await _crudService.Delete(id);
        }

        public async Task<TDto> GetById(int id)
        {
            var entity = await _crudService.GetById(id);
            var dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        public Task<IQueryable<TEntity>> Query()
        {
            return Task.FromResult(_crudService.Query());
        }

        public virtual async Task<TDto> Update(int id, TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _crudService.Update(id, entity);
            return _mapper.Map(entity, dto);
        }

        public virtual async Task<List<TDto>> Get(int top)
        {
            var result = await _crudService.Get(top);
            return _mapper.Map<List<TDto>>(result);
        }

        public virtual async Task<TDto> Update(TDto dto)
        {
            var entity = _mapper.Map<TEntity>(dto);
            entity = await _crudService.Update(entity);
            return _mapper.Map(entity, dto);
        }

        
    }
}
