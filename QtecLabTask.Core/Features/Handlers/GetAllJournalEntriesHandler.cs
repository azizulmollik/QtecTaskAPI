using AutoMapper;
using MediatR;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Features.Queries;
using QtecLabTask.Core.Services;

namespace QtecLabTask.Core.Features.Handlers
{
    public class GetAllJournalEntriesHandler : IRequestHandler<GetAllJournalEntriesQuery, List<JournalEntryDto>>
    {
        private readonly IJournalEntryService _service;
        private readonly IMapper _mapper;

        public GetAllJournalEntriesHandler(IJournalEntryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<List<JournalEntryDto>> Handle(GetAllJournalEntriesQuery request, CancellationToken cancellationToken)
        {
            var entries = await _service.GetAllAsync();
            return _mapper.Map<List<JournalEntryDto>>(entries);
        }
    }
}
