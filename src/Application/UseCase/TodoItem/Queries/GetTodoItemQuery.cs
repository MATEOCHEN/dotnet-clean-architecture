using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.UseCase.TodoItem.Queries;

public class GetTodoItemQuery : IRequest<string>
{
    public int Id { get; set; }
}

public class GetTodoItemQueryHandler : IRequestHandler<GetTodoItemQuery, string>
{
    private readonly ITemplateContext _dataContext;

    public GetTodoItemQueryHandler(ITemplateContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<string> Handle(GetTodoItemQuery request, CancellationToken cancellationToken)
    {
        var todoItem = await _dataContext
            .TodoItems
            .FirstAsync(x => x.Id == request.Id, cancellationToken);
        return $"get todo item with Name:{todoItem.TaskName}";
    }
}
