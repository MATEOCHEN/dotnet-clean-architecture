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
            .MapPost(() => CreateTodoItem, "item/{id:int}")
            .MapPut(() => UpdateTodoItem, "item/{id:int}")
            .MapDelete(() => DeleteTodoItem, "item/{id:int}");
    }

    private async Task<string> GetTodoItem(ISender sender, int id)
    {
        return await sender.Send(new GetTodoItemQuery
        {
            Id = id
        });
    }

    private string CreateTodoItem(int id)
    {
        return $"create todo item {id}";
    }

    private string UpdateTodoItem(int id)
    {
        return $"update todo item {id}";
    }

    private string DeleteTodoItem(int id)
    {
        return $"delete todo item {id}";
    }
}

