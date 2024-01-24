using MediatR;

namespace Application.UseCase.TodoItem.Commands.DeleteTodoItem;

public class DeleteTodoItemCommand : IRequest<string>
{
    public int Id { get; set; }
}

public class DeleteTodoItemCommandHandler : IRequestHandler<DeleteTodoItemCommand, string>
{
    public async Task<string> Handle(DeleteTodoItemCommand request, CancellationToken cancellationToken)
    {
        return $"delete todo item id {request.Id} successfully";
    }
}