using ShiftSystem.Application.Generic.Interfaces;
using ShiftSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Interfaces
{
    public interface IPersonService : IBaseCrudService<Domain.Entities.Person>
    {

    }
}
