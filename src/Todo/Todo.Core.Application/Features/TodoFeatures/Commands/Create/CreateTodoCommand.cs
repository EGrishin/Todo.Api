using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Core.Application.Features.TodoFeatures.Commands.Create
{
    public class CreateTodoCommand : IRequest<Domain.Entities.Todo>
    {
        public string Title { get; set; }

        public string Description { get; set; }

    }
}
