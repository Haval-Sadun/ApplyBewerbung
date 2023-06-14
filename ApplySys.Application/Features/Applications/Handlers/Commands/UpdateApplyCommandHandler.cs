using ApplySys.Application.DTOs.Apply.Validators;
using ApplySys.Application.Features.Applications.Requests.Commands;
using ApplySys.Application.Contracts.Persistence;
using ApplySys.Application.Exceptions;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Features.Applications.Handlers.Commands
{
    public class UpdateApplyCommandHandler : IRequestHandler<UpdateApplyCommand, Unit>
    {
        private readonly IApplyRepository _applyRepository;
        private readonly IMapper _mapper;

        public UpdateApplyCommandHandler(IApplyRepository applyRepository, IMapper mapper)
        {
            _applyRepository = applyRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateApplyCommand request, CancellationToken cancellationToken)
        {
            var validator = new UpdateApplyValidator();
            var validationResult = await validator.ValidateAsync(request.ApplyDto);
                
            if (validationResult.IsValid == false)
                throw new VaildationException(validationResult);

            var apply = await _applyRepository.Get(request.ApplyDto.Id);
            _mapper.Map(request.ApplyDto, apply);
            await _applyRepository.Update(apply);

            return Unit.Value;
        }
    }
}
/*
 * Get it
 * map it
 * update it
 */