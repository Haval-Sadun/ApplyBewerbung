using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply.Validators
{
    public class IApplyDtoValidator : AbstractValidator<IApplyDto>
    {
        public IApplyDtoValidator()
        {

            RuleFor(a => a.Title)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .MaximumLength(100);

            RuleFor(a => a.CompanyName)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(100);

            RuleFor(e => e.JobType).IsInEnum().NotNull();

            RuleFor(e => e.State).IsInEnum().NotNull();

            RuleFor(a => a.Link)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull();

        }
    }
}
