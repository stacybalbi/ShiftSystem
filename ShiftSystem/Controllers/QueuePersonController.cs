using Microsoft.AspNetCore.Mvc;
using ShiftSystem.Application.Queue.Handlers;
using ShiftSystem.Application.QueuePerson.Dto;
using ShiftSystem.Application.QueuePerson.Handlers;

namespace ShiftSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QueuePersonController : ControllerBase
    {
        private readonly IQueuePersonHandler _queuePersonHandler;
        public QueuePersonController(IQueuePersonHandler queuePersonHandler)
        {
            _queuePersonHandler = queuePersonHandler;
        }


        [HttpGet("{queueId}")]
        public async Task<IActionResult> Get([FromRoute] int queueId)
        {
            var entitiesToReturn = await _queuePersonHandler.GetByQueueId(queueId);

            if (entitiesToReturn == null)
                return NotFound();

            return Ok(entitiesToReturn);
        }


        [HttpPost("Put")]
        public async Task<IActionResult> Put([FromBody] QueuePersonDto queuePerson)
        {
            try
            {
                await _queuePersonHandler.Put(queuePerson);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

        [HttpPost("Push/{queueId}")]
        public async Task<IActionResult> Push([FromRoute] int queueId)
        {
            try
            {
                await _queuePersonHandler.Push(queueId);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }

    }
}
