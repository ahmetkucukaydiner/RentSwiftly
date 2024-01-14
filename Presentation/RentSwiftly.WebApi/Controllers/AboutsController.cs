using Microsoft.AspNetCore.Mvc;
using RentSwiftly.Application.Features.CQRS.Commands.AboutCommands;
using RentSwiftly.Application.Features.CQRS.Handlers.AboutHandlers;
using RentSwiftly.Application.Features.CQRS.Queries.AboutQueries;

namespace RentSwiftly.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly CreateAboutCommandHandler _createCommandHandler;
        private readonly DeleteAboutCommandHandler _deleteCommandHandler;
        private readonly UpdateAboutCommandHandler _updateCommandHandler;
        private readonly GetAboutByIdQueryHandler _getAboutByIdQueryHandler;
        private readonly GetAboutQueryHandler _getAboutQueryHandler;

        public AboutsController(CreateAboutCommandHandler createCommandHandler, DeleteAboutCommandHandler deleteCommandHandler, UpdateAboutCommandHandler updateCommandHandler, GetAboutByIdQueryHandler getAboutByIdQueryHandler, GetAboutQueryHandler getAboutQueryHandler)
        {
            _createCommandHandler = createCommandHandler;
            _deleteCommandHandler = deleteCommandHandler;
            _updateCommandHandler = updateCommandHandler;
            _getAboutByIdQueryHandler = getAboutByIdQueryHandler;
            _getAboutQueryHandler = getAboutQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> AboutList()
        {
            var values = await _getAboutQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetAbout(int id)
        {
            var value = await _getAboutByIdQueryHandler.Handle(new GetAboutByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok("Hakkımda bilgisi oluşturuldu");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAbout(int id)
        {
            await _deleteCommandHandler.Handle(new DeleteAboutCommand(id));
            return Ok("Hakkımda bilgisi silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAbout(UpdateAboutCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok("Hakkımda bilgisi güncellendi.");
        }
    }
}
