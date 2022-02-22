using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Todo.Core.Application.Interfaces;

namespace Todo.Core.Application.Features.TodoFeatures.Queries.ListAll
{
    public class ListAllQueryHandler : IRequestHandler<ListAllQuery, IEnumerable<Domain.Entities.Todo>>
    {
        private readonly IApplicationDbContext _context;

        public ListAllQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Domain.Entities.Todo>> Handle(ListAllQuery request, CancellationToken cancellationToken)
        {
            var todosList = await _context.Todos.ToListAsync();

            if(todosList == null)
            {
                return null;
            }

            return todosList.AsReadOnly();
        }
    }
}
