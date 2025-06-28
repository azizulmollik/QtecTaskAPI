using AutoMapper;
using MediatR;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Features.Queries;
using QtecLabTask.Core.Repositories;


namespace QtecLabTask.Core.Features.Handlers
{
    public class GetAllAccountsHandler : IRequestHandler<GetAllAccountsQuery, List<AccountDto>>
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public GetAllAccountsHandler(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<List<AccountDto>> Handle(GetAllAccountsQuery request, CancellationToken cancellationToken)
        {
            var accounts = await _accountService.GetAllAsync();
            return _mapper.Map<List<AccountDto>>(accounts);
        }

    }
}
