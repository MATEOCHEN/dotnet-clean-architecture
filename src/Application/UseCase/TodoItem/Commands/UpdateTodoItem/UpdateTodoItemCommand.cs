using MediatR;

namespace Application.UseCase.TodoItem.Commands.UpdateTodoItem;

public class UpdateTodoItemCommand : IRequest<string>
{
    public int Id { get; set; }
}

public class UpdateTodoItemCommandHandler : IRequestHandler<UpdateTodoItemCommand, string>
{
    public async Task<string> Handle(UpdateTodoItemCommand request, CancellationToken cancellationToken)
    {
        return $"update todo item id {request.Id}";
    }
}
