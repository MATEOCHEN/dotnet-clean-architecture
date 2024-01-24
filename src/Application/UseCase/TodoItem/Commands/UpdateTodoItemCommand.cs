using MediatR;

namespace Application.UseCase.TodoItem.Commands;

public class UpdateTodoItemCommand : IRequest<string>
{
    public int Id { get; set; }
}