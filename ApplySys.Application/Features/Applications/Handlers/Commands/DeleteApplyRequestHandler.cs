using ApplySys.Application.Exceptions;
using ApplySys.Application.Features.Applications.Requests.Commands;
using ApplySys.Application.Contracts.Persistence;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.Features.Applications.Handlers.Commands
{
    public class DeleteApplyRequestHandler : IRequestHandler<DeleteApplyRequest>
    {
        private readonly IApplyRepository _applyRepository;
        private readonly IMapper _mapper;

        public DeleteApplyRequestHandler(IApplyRepository applyRepository, IMapper mapper)
        {
            _applyRepository = applyRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(DeleteApplyRequest request, CancellationToken cancellationToken)
        {
            var apply = await _applyRepository.Get(request.Id);

            if (apply == null)
                throw new NotFoundException(nameof(apply), request.Id);

            await _applyRepository.Delete(apply);
            return Unit.Value;
        }

        Task IRequestHandler<DeleteApplyRequest>.Handle(DeleteApplyRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
