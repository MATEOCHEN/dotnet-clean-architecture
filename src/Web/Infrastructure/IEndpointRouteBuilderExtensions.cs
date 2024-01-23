namespace clean_architecture_template.Infrastructure;

public static class EndpointRouteBuilderExtensions
{
    public static IEndpointRouteBuilder MapGet(
        this IEndpointRouteBuilder builder,
        Delegate handler,
        string pattern = ""
    )
    {
        builder.MapGet(pattern, handler).WithName(handler.Method.Name);

        return builder;
    }

    public static IEndpointRouteBuilder MapPost(
        this IEndpointRouteBuilder builder,
        Delegate handler,
        string pattern = ""
    )
    {
        builder
            .MapPost(pattern, handler)
            .AddEndpointFilter<ApiKeyFilter>()
            .WithName(handler.Method.Name);

        return builder;
    }

    public static IEndpointRouteBuilder MapPut(
        this IEndpointRouteBuilder builder,
        Delegate handler,
        string pattern
    )
    {
        builder
            .MapPut(pattern, handler)
            .AddEndpointFilter<ApiKeyFilter>()
            .WithName(handler.Method.Name);

        return builder;
    }

    public static IEndpointRouteBuilder MapDelete(
        this IEndpointRouteBuilder builder,
        Delegate handler,
        string pattern
    )
    {
        builder
            .MapDelete(pattern, handler)
            .AddEndpointFilter<ApiKeyFilter>()
            .WithName(handler.Method.Name);

        return builder;
    }
}

public class ApiKeyFilter : IEndpointFilter
{
    public async ValueTask<object?> InvokeAsync(
        EndpointFilterInvocationContext context,
        EndpointFilterDelegate next
    )
    {
        var requestApiKey = context.HttpContext.Request.Headers["X-API-KEY"].ToString();

        if (requestApiKey is not "custom api key")
            throw new UnauthorizedAccessException("Access denied.");

        var result = await next(context);

        return result;
    }
}
