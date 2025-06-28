using Microsoft.EntityFrameworkCore;
using QtecLabTask.Core.Data;
using QtecLabTask.Core.Entities;

namespace QtecLabTask.Core.Repositories
{
    public interface IAccountRepository {
        Task AddAsync(Account account);
        Task<List<Account>> GetAllAsync();
    }


    public class AccountRepository: IAccountRepository
    {
        private readonly QtecLabDbContext _dbContext;
        public AccountRepository(QtecLabDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Account account)
        {
            _dbContext.Accounts.Add(account);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Account>> GetAllAsync()
        {
            return await _dbContext.Accounts.ToListAsync();
        }
    }
}
