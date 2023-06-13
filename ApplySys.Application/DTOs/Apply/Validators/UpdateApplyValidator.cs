using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply.Validators
{
    internal class UpdateApplyValidator : AbstractValidator<UpdateApplyDto>
    {
        public UpdateApplyValidator()
        {
            Include(new IApplyDtoValidator());

            RuleFor(a => a.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
