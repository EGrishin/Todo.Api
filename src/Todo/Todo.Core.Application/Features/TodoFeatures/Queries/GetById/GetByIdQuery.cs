using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Core.Application.Features.TodoFeatures.Queries.GetById
{
    public class GetByIdQuery : IRequest<Domain.Entities.Todo>
    {
        public Guid Id { get; set; }
    }
}
