using QtecLabTask.Core.Entities;
using QtecLabTask.Core.Repositories;

namespace QtecLabTask.Core.Services
{
    public interface IJournalEntryService
    {
        Task AddAsync(JournalEntry journalEntry);
        Task<List<JournalEntry>> GetAllAsync();
    }

    public class JournalEntryService : IJournalEntryService
    {
        private readonly IJournalEntryRepository _repository;
        public JournalEntryService(IJournalEntryRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(JournalEntry journalEntry)
        {
            await _repository.AddAsync(journalEntry);
        }

        public async Task<List<JournalEntry>> GetAllAsync()
        {
            var response = await _repository.GetAllAsync();
            return await Task.FromResult(response);
        }
    }
}
