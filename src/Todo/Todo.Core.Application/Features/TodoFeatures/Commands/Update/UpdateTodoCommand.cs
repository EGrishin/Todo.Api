using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Core.Application.Features.TodoFeatures.Commands.Update
{
    public class UpdateTodoCommand : IRequest<Domain.Entities.Todo>
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsFinished { get; set; }
    }
}
