using System.Reflection;

namespace Application;

public static class DependencyInjection
{
    public static void AddApplicationServices(this IServiceCollection service)
    {
        service.AddMediatR(
            cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly())
        );
    }
}
