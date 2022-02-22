using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Todo.Core.Application.Interfaces;

namespace Todo.Core.Application.Features.TodoFeatures.Commands.Delete
{
    public class DeleteTodoCommandHandler : IRequestHandler<DeleteTodoCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public DeleteTodoCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(DeleteTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = await _context.Todos.FirstOrDefaultAsync(t =>t.Id == request.Id, cancellationToken: cancellationToken);

            if(todo == null)
            {
                return default;
            }
            else
            {
                _context.Todos.Remove(todo);

                await _context.SaveChangesAsync();

                return todo.Id;
            }
        }
    }
}
