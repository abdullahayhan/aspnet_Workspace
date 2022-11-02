using Directory.MODEL.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.MODEL.FluentValidators
{
    public class PersonValidator: AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(x=>x.FirstName).NotEmpty().NotNull().WithMessage("Zorunlu Alan")
                .MaximumLength(15).WithMessage("Max 15 karakter girebilirsiniz");
            RuleFor(x => x.LastName).NotEmpty().NotNull().WithMessage("Zorunlu Alan")
                .MaximumLength(15).WithMessage("Max 15 karakter girebilirsiniz");
            RuleFor(x => x.PhoneNumber).NotEmpty().NotNull().WithMessage("Zorunlu Alan")
                .MaximumLength(15).WithMessage("Max 15 karakter girebilirsiniz");
            
        }
    }
}
