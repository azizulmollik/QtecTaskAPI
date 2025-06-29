using Microsoft.EntityFrameworkCore;
using QtecLabTask.Core.Data;
using QtecLabTask.Core.Entities;

namespace QtecLabTask.Core.Repositories
{
    public interface IJournalEntryRepository
    {
        Task AddAsync(JournalEntry journalEntry);
        Task<List<JournalEntry>> GetAllAsync();
    }

    public class JournalEntryRepository : IJournalEntryRepository
    {
        private readonly QtecLabDbContext _dbContext;
        public JournalEntryRepository(QtecLabDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(JournalEntry journalEntry)
        {
            _dbContext.JournalEntries.Add(journalEntry);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<JournalEntry>> GetAllAsync()
        {
            var entries = await _dbContext.JournalEntries
               .Include(j => j.JournalEntryLine)
               .ToListAsync();

            return entries;
        }

    }
}
