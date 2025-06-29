using MediatR;
using QtecLabTask.Core.DTOs;

namespace QtecLabTask.Core.Features.Queries
{
    public class GetAllJournalEntriesQuery : IRequest<List<JournalEntryDto>> { }
}
