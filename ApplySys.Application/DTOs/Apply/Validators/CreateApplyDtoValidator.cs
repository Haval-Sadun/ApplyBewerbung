using ApplySys.Application.Contracts.Persistence;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply.Validators
{
    public class CreateApplyDtoValidator : AbstractValidator<CreateApplyDto>
    {
        public CreateApplyDtoValidator()
        {
            Include(new IApplyDtoValidator());
        }
    }
}






/*
 * RuleFor(e => e.State)
                .NotEmpty()
                .MustAsync(async (xxx, token) =>
                {
                    var applyExists = await _applyRepository.Exists(xxx);
                    return !applyExists;
                }).WithMessage("{PropertyName} doesnt exist");
*/