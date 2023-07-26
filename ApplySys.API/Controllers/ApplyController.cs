using ApplySys.Application.DTOs.Apply;
using ApplySys.Application.Features.Applications.Requests.Commands;
using ApplySys.Application.Features.Applications.Requests.Queries;
using ApplySys.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApplySys.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ApplyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApplyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<ApplyController>
        [HttpGet]
        public async Task<ActionResult<List<ApplyDto>>> Get()
        {
            var apply = await _mediator.Send(new GetApplyListRequest());
            return Ok(apply);
        }

        // GET api/<ApplyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ApplyDto>> Get(int id)
        {
            var apply = await _mediator.Send(new GetApplyDetailRequest { Id= id });
            return Ok(apply);
        }

        // POST api/<ApplyController>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<BaseCommandResponse>> Post([FromBody] CreateApplyDto apply)
        {
            var command =  new CreateApplyCommand { ApplyDto= apply };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        //id is optional , we dont need it 
        // PUT api/<ApplyController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(int id, [FromBody] UpdateApplyDto apply)
        {
            var command = new UpdateApplyCommand { ApplyDto= apply };
            await _mediator.Send(command);

            return NoContent();
        }

        // DELETE api/<ApplyController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteApplyCommand { Id= id });    
            return NoContent();
        }
    }
}
