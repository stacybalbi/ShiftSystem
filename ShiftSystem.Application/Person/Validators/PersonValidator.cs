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
            RuleFor(x => x.Name)
                .EmailAddress()
                .WithName("Invalid-name")
                .WithMessage("Invalid Name");

            RuleFor(x => x.status)
                .NotEmpty()
                .WithName("Invalid-name")
                .WithMessage("Invalid Status");


        }
    }
}
