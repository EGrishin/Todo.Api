using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Todo.Core.Application.Features.TodoFeatures.Commands.Create;
using Todo.Core.Application.Features.TodoFeatures.Commands.Delete;
using Todo.Core.Application.Features.TodoFeatures.Commands.Update;
using Todo.Core.Application.Features.TodoFeatures.Queries.ListAll;
using Todo.Core.Application.Features.TodoFeatures.Queries.GetById;

namespace Todo.Api.Controllers.v1
{
    [ApiVersion("1.0")]
    public class TodoController : BaseApiController
    {
        /// <summary>
        /// Создание новой Todo
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Create(CreateTodoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// Удаление Todo по Id
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            return Ok(await Mediator.Send(new DeleteTodoCommand { Id = id}));
        }

        /// <summary>
        /// Изменение Todo
        /// </summary>
        [HttpPut("[action]")]
        public async Task<IActionResult> Update(Guid id, UpdateTodoCommand command)
        {
            if(id != command.Id)
            {
                return BadRequest();
            }

            return Ok(await Mediator.Send(command));
        }

        /// <summary>
        /// Получение списка всех Todo
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await Mediator.Send(new ListAllQuery()));
        }

        /// <summary>
        /// Получение Todo по Id
        /// </summary>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            return Ok(await Mediator.Send(new GetByIdQuery { Id = id}));
        }
    }
}
