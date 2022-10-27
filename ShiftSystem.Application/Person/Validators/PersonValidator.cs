using FluentValidation;
using ShiftSystem.Application.Person.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShiftSystem.Application.Person.Validators
{
    public class PersonValidator : AbstractValidator<PersonDto>
    {
        public PersonValidator()
        {
            RuleFor(x => x.Weight).NotEmpty().WithMessage("Weight is required");
            RuleFor(x => x.Height).NotEmpty().WithMessage("Height is required");
            RuleFor(x => x.fileUri).NotEmpty().WithMessage("FileUri is required");
            RuleFor(x => x.Age).NotEmpty().WithMessage("Age is required");
        }
    }
}
