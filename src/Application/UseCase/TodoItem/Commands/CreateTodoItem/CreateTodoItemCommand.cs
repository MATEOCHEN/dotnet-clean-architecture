using MediatR;

namespace Application.UseCase.TodoItem.Commands.CreateTodoItem;

public class CreateTodoItemCommand : IRequest<string>
{
    public string Name { get; set; }
}

public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, string>
{
    public async Task<string> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
    {
        return $"create todo item with name {request.Name}";
    }
}