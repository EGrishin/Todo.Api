using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Todo.Core.Application.Interfaces;

namespace Todo.Core.Application.Features.TodoFeatures.Commands.Update
{
    public class UpdateTodoCommandHandler : IRequestHandler<UpdateTodoCommand, Domain.Entities.Todo>
    {
        private readonly IApplicationDbContext _context;

        public UpdateTodoCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Todo> Handle(UpdateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = _context.Todos.FirstOrDefault(t=>t.Id == request.Id);

            if(todo == null)
            {
                return default;
            }
            else
            {
                todo.Title = request.Title;
                todo.Description = request.Description;
                todo.UpdatedDate = DateTime.Now;
                todo.IsFinished = request.IsFinished;

                if(todo.IsFinished)
                {
                    todo.FinishedDate = DateTime.Now;
                }

                await _context.SaveChangesAsync();

                return todo;
            }


        }
    }
}
