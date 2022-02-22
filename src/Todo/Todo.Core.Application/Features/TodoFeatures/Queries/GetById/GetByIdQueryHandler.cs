using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Todo.Core.Application.Interfaces;

namespace Todo.Core.Application.Features.TodoFeatures.Queries.GetById
{
    public class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, Domain.Entities.Todo>
    {
        private readonly IApplicationDbContext _context;

        public GetByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Todo> Handle(GetByIdQuery request, CancellationToken cancellationToken)
        {
            var todo = _context.Todos.FirstOrDefault(t => t.Id == request.Id);

            if(todo == null)
            {
                return default;
            }

            return todo;
        }
    }
}
