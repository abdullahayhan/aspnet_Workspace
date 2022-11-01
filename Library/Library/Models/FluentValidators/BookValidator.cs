using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.FluentValidators
{
    public class BookValidator:AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Zorunlu Alan")
                .MaximumLength(15).WithMessage("Max 15 karakter girebilirsiniz");
            When(x=>x.Name=="Deneme", () => 
            {
                RuleFor(x => x.PageCount).Must(x =>x == 50).WithMessage("İsim deneme ise sayfa sayısı 50 olmalı.");
            });

            // RuleFor(x=>x.PageCount).Must(y=> int.TryParse(y,out int value)&& value>50).WithMessage("Lütfen Sayfa sayısını sayı ile ifade edin.");
        }
    }
}
