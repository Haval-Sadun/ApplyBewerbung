using ApplySys.Application.DTOs.Apply;
using ApplySys.Application.DTOs.Apply.Validators;
using ApplySys.Application.Exceptions;
using ApplySys.Application.Features.Applications.Requests.Commands;
using ApplySys.Application.Contracts.Persistence;
using ApplySys.Application.Responses;
using ApplySys.Domain.Entities;
using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplySys.Application.Contracts.Infrastructure;
using ApplySys.Application.Models;

namespace ApplySys.Application.Features.Applications.Handlers.Commands
{
    public class CreateApplyRequestHandler : IRequestHandler<CreateApplyRequest, BaseCommandResponse>
    {
        private readonly IApplyRepository _applyRepository;
        private readonly IMapper _mapper;
        private readonly IEmailSender _emailSender;

        public CreateApplyRequestHandler(IApplyRepository applyRepository, IMapper mapper, IEmailSender emailSender)
        {
            _applyRepository = applyRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }


        public async Task<BaseCommandResponse> Handle(CreateApplyRequest request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var validator = new CreateApplyDtoValidator();
            var validatorResult = await validator.ValidateAsync(request.ApplyDto);
            if (validatorResult.IsValid == false)
            {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validatorResult.Errors.Select(e=> e.ErrorMessage).ToList();    
            }

            var apply = _mapper.Map<Apply>(request.ApplyDto);
            apply = await _applyRepository.Add(apply);

            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = apply.Id;

            var email = new Email
            {
                To = "employee@gmail.com",
                Subject = "Apply Submitted",
                Body = $" your apply for {request.ApplyDto.Title} is successfully submitted"
            };
            try
            {
                await _emailSender.SendEmailAsync(email);
            }
            catch (Exception ex)
            {

            }

            return response;
        }
    }
}
