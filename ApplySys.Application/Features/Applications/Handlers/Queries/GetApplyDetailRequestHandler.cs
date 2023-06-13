using ApplySys.Application.DTOs.Apply;
using ApplySys.Application.Features.Applications.Requests.Queries;
using ApplySys.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Features.Applications.Handlers.Queries
{
    public class GetApplyDetailRequestHandler : IRequestHandler<GetApplyDetailRequest, ApplyDto>
    {
        private readonly IApplyRepository _applyRepository;
        private readonly IMapper _mapper;

        public GetApplyDetailRequestHandler(IApplyRepository applyRepository, IMapper mapper)
        {
            _applyRepository = applyRepository;
            _mapper = mapper;
        }
        public async Task<ApplyDto> Handle(GetApplyDetailRequest request, CancellationToken cancellationToken)
        {
            var apply = await _applyRepository.Get(request.Id);
            return _mapper.Map<ApplyDto>(apply);
        }
    }
}
