using Application.UseCase.TodoItem.Commands;
using Application.UseCase.TodoItem.Commands.CreateTodoItem;
using Application.UseCase.TodoItem.Queries;
using clean_architecture_template.Infrastructure;
using MediatR;

namespace clean_architecture_template.Endpoints;

public class Todo : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .MapGet(GetTodoItem, "item/{id:int}")
            .MapPost((CreateTodoItemRequest _) => CreateTodoItem, "item")
            .MapPut(() => UpdateTodoItem, "item/{id:int}")
            .MapDelete(() => DeleteTodoItem, "item/{id:int}");
    }

    private async Task<string> GetTodoItem(ISender sender, int id)
    {
        return await sender.Send(new GetTodoItemQuery { Id = id });
    }

    private async Task<string> CreateTodoItem(ISender sender, CreateTodoItemRequest request)
    {
        return await sender.Send(new CreateTodoItemCommand { Name = request.Name });
    }

    private async Task<string> UpdateTodoItem(ISender sender, int id)
    {
        return await sender.Send(new UpdateTodoItemCommand { Id = id });
    }

    private async Task<string> DeleteTodoItem(ISender sender, int id)
    {
        return await sender.Send(new DeleteTodoItemCommand { Id = id });
    }
}

public class CreateTodoItemRequest
{
    public string Name { get; set; }
}
