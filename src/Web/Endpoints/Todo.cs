using clean_architecture_template.Infrastructure;

namespace clean_architecture_template.Endpoints;

public class Todo : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this).MapGet((int id) => $"get todo item list {id}", "item")
            .MapPost(() => "create todo item", "item")
            .MapPut((int id) => $"full update todo item {id}", "item")
            .MapDelete((int id) => $"delete todo item {id}", "item");
    }
}
