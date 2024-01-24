using MediatR;

namespace Application.UseCase.TodoItem.Commands;

public class DeleteTodoItemCommand : IRequest<string>
{
    public int Id { get; set; }
}