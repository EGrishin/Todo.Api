using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Todo.Core.Application.Interfaces;

namespace Todo.Core.Application.Features.TodoFeatures.Commands.Create
{
    public class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Domain.Entities.Todo>
    {
        private readonly IApplicationDbContext _context;

        public CreateTodoCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Todo> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var todo = new Domain.Entities.Todo
            {
                Title = request.Title,
                Description = request.Description
            };

            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();

            return todo;
        }
    }
}
