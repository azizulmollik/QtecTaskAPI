using MediatR;
using QtecLabTask.Core.DTOs;

namespace QtecLabTask.Core.Features.Queries
{
    public class GetAllAccountsQuery : IRequest<List<AccountDto>> { }
}
