using MediatR;
using Microsoft.AspNetCore.Mvc;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Features.Commands;
using QtecLabTask.Core.Features.Queries;

namespace QtecLabTask.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<AccountsController>
        [HttpGet]
        public async Task<ActionResult<List<AccountDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllAccountsQuery());
            return Ok(result);
        }

        // POST api/<AccountsController>
        [HttpPost]
        public async Task<ActionResult<AccountDto>> Create(AccountDto dto)
        {
            var result = await _mediator.Send(new CreateAccountCommand { AccountDto = dto });
            return CreatedAtAction(nameof(Get), new { id = result.Id }, result);
        }

    }
}
