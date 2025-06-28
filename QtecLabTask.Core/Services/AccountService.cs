using QtecLabTask.Core.Entities;

namespace QtecLabTask.Core.Repositories
{
    public interface IAccountService
    {
        Task AddAsync(Account account);
        Task<List<Account>> GetAllAsync();
    }


    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository) {
            _accountRepository = accountRepository;
        }

        public async Task AddAsync(Account account)
        {
            await _accountRepository.AddAsync(account);
        }

        public async Task<List<Account>> GetAllAsync()
        {
            var response = await _accountRepository.GetAllAsync();
            return await Task.FromResult(response);
        }
    }
}
