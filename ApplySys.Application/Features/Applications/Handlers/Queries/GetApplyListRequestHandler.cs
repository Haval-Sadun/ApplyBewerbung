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

namespace ApplySys.Application.Features.Applies.Handlers.Queries
{
    public class GetApplyListRequestHandler : IRequestHandler<GetApplyListRequest, List<ApplyDto>>
    {
        private readonly IApplyRepository _applyRepository;
        private readonly IMapper _mapper;

        public GetApplyListRequestHandler(IApplyRepository applyRepository,IMapper mapper)
        {
            _applyRepository = applyRepository;
            _mapper = mapper;
        }
        public async Task<List<ApplyDto>> Handle(GetApplyListRequest request, CancellationToken cancellationToken)
        {
            var applies = await _applyRepository.GetAll();
            return _mapper.Map<List<ApplyDto>>(applies);
        }
    }
}
