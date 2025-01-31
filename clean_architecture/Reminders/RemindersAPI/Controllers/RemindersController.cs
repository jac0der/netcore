using Application.UseCases;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace RemindersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RemindersController : ControllerBase
    {
        private readonly CreateReminderUseCase _createReminderUseCase;

        public RemindersController(CreateReminderUseCase createReminderUseCase)
        {
            _createReminderUseCase = createReminderUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReminder([FromBody] Reminder request)
        {
            var reminder = await _createReminderUseCase.Execute(request.Title, request.Description);
            return CreatedAtAction(nameof(GetReminder), new { id = reminder.Id }, reminder);
        }

        [HttpGet("{id}")]
        public IActionResult GetReminder(Guid id)
        {
            // Implementation here
            return Ok();
        }
    }
}