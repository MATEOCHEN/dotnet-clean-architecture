using MediatR;

namespace Application.UseCase.TodoItem.Queries;

public class GetTodoItemQuery : IRequest<string>
{
    public int Id { get; set; }
}
public class GetTodoItemQueryHandler : IRequestHandler<GetTodoItemQuery, string>
{
    public async Task<string> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
    {
        return $"get todo item {request.Id}";
    }
}
