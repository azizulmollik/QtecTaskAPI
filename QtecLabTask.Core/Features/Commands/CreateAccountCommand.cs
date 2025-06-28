using MediatR;
using QtecLabTask.Core.DTOs;

namespace QtecLabTask.Core.Features.Commands
{
    public class CreateAccountCommand : IRequest<AccountDto>
    {
        public AccountDto AccountDto { get; set; }
    }
}
