using MediatR;
using System;

namespace Todo.Core.Application.Features.TodoFeatures.Commands.Delete
{
    public class DeleteTodoCommand : IRequest<Guid>
    {
        public Guid Id { get; set; }
    }
}
