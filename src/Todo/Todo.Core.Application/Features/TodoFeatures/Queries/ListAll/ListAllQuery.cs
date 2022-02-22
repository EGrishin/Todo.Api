using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Core.Application.Features.TodoFeatures.Queries.ListAll
{
    public class ListAllQuery : IRequest<IEnumerable<Domain.Entities.Todo>>
    {
    }
}
