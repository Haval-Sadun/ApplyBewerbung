using ApplySys.Application.DTOs.Apply;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Features.Applications.Requests.Queries
{
    public class GetApplyDetailRequest : IRequest<ApplyDto>
    {
        public Guid Id { get; set; }
    }
}
