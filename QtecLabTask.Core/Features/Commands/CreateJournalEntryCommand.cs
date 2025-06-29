using MediatR;
using QtecLabTask.Core.DTOs;

namespace QtecLabTask.Core.Features.Commands
{
    public class CreateJournalEntryCommand : IRequest<JournalEntryDto>
    {
        public JournalEntryDto Entry { get; set; }
    }
}
