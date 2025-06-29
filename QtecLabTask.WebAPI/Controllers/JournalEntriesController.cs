using MediatR;
using Microsoft.AspNetCore.Mvc;
using QtecLabTask.Core.DTOs;
using QtecLabTask.Core.Features.Commands;
using QtecLabTask.Core.Features.Queries;

namespace QtecLabTask.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JournalEntriesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<JournalEntryDto>> Create(JournalEntryDto dto)
        {
            var result = await _mediator.Send(new CreateJournalEntryCommand { Entry = dto });
            return CreatedAtAction(nameof(GetAll), new { id = result.Id }, result);
        }

        [HttpGet]
        public async Task<ActionResult<List<JournalEntryDto>>> GetAll()
        {
            var result = await _mediator.Send(new GetAllJournalEntriesQuery());
            return Ok(result);
        }
    }
}
