
using AutoMapper;
using MediatR;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Entities;
using QtecLabTask.Core.Features.Commands;
using QtecLabTask.Core.Repositories;
using System;

namespace QtecLabTask.Core.Features.Handlers
{
    public class CreateAccountHandler : IRequestHandler<CreateAccountCommand, AccountDto>
    {
        private readonly IAccountService _accountService;
        private readonly IMapper _mapper;

        public CreateAccountHandler(IAccountService accountService, IMapper mapper)
        {
            _accountService = accountService;
            _mapper = mapper;
        }

        public async Task<AccountDto> Handle(CreateAccountCommand request, CancellationToken cancellationToken)
        {
            var account = _mapper.Map<Account>(request.AccountDto);
            await _accountService.AddAsync(account);            
            return _mapper.Map<AccountDto>(account);
        }
    }
}
