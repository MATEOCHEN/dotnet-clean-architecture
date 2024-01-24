namespace clean_architecture_template;

public static class DependencyInjection
{
    public static void AddWebServices(this IServiceCollection service)
    {
        service.AddEndpointsApiExplorer();
        service.AddSwaggerGen();
    }
}