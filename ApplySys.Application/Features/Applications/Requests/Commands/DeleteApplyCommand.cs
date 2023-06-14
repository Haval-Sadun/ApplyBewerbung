using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Features.Applications.Requests.Commands
{
    public class DeleteApplyCommand : IRequest
    {
        public int Id { get; set; }
    }
}
