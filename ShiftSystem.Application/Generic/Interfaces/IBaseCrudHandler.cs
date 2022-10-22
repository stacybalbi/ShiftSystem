using ShiftSystem.Application.Generic.Dto;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Generic.Interfaces
{
    public interface IBaseCrudHandler<TDto, TEntity> where TDto : BaseDto where TEntity : BaseEntity
    {
        Task<IQueryable<TEntity>> Query();
        Task<TDto> GetById(int id);
        Task<TDto> Create(TDto dto);
        Task<TDto> Update(int id, TDto dto);
        Task<TDto> Update(TDto dto);
        Task<bool> Delete(int id);
    }
}
