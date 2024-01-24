using Application.Common.Interfaces;
using MediatR;

namespace Application.UseCase.TodoItem.Commands.CreateTodoItem;

public class CreateTodoItemCommand : IRequest<string>
{
    public string Name { get; set; }
}

public class CreateTodoItemCommandHandler : IRequestHandler<CreateTodoItemCommand, string>
{
    private readonly ITemplateContext _dataContext;

    public CreateTodoItemCommandHandler(ITemplateContext dataContext)
    {
        _dataContext = dataContext;
    }
    public async Task<string> Handle(CreateTodoItemCommand request, CancellationToken cancellationToken)
    {
        await _dataContext.TodoItems.AddAsync(new Domain.Entities.TodoItem
        {
            TaskName = request.Name,
            Done = false,
            CreateOn = DateTime.UtcNow,
        }, cancellationToken);
        return $"create todo item with name {request.Name}";
    }
}