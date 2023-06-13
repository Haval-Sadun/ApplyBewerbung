using ApplySys.Application.DTOs.Apply;
using ApplySys.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Features.Applications.Requests.Commands
{
    public class CreateApplyRequest : IRequest<BaseCommandResponse>
    {
        public CreateApplyDto ApplyDto { get; set; }
    }
}
