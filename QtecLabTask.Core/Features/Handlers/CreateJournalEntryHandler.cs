using AutoMapper;
using MediatR;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Entities;
using QtecLabTask.Core.Features.Commands;
using QtecLabTask.Core.Services;

namespace QtecLabTask.Core.Features.Handlers
{
    public class CreateJournalEntryHandler : IRequestHandler<CreateJournalEntryCommand, JournalEntryDto>
    {
        private readonly IJournalEntryService _service;
        private readonly IMapper _mapper;

        public CreateJournalEntryHandler(IJournalEntryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<JournalEntryDto> Handle(CreateJournalEntryCommand request, CancellationToken cancellationToken)
        {
            var entry = _mapper.Map<JournalEntry>(request.Entry);
            await _service.AddAsync(entry);
            return _mapper.Map<JournalEntryDto>(entry);
        }
    }
}
