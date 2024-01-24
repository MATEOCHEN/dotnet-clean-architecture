using Microsoft.OpenApi.Models;

namespace clean_architecture_template;

public static class DependencyInjection
{
    public static void AddWebServices(this IServiceCollection service)
    {
        service.AddEndpointsApiExplorer();
        service.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Template API",
                Description = "the clean architecture template api",
                Version = "v1",
                Contact = new OpenApiContact
                {
                    Name = "Steven Chen",
                    Email = "steven.chen@soohoobook.com",
                }
            });
            options.AddSecurityDefinition("Bearer",new OpenApiSecurityScheme
            {
                Type = SecuritySchemeType.ApiKey,
                Name = "Authorization",
                In = ParameterLocation.Header,
                Scheme = "Bearer",
                BearerFormat = "JWT",
                Description = "JWT Authorization"
            });
        });
    }
}