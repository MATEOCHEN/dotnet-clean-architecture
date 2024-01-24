using Microsoft.OpenApi.Models;

namespace clean_architecture_template;

public static class DependencyInjection
{
    public static void AddWebServices(this IServiceCollection service)
    {
        service.AddEndpointsApiExplorer();
        service.AddSwaggerGen(options =>
        {
            options.SwaggerDoc(
                "v1",
                new OpenApiInfo
                {
                    Title = "Template API",
                    Description = "the clean architecture template api",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "Steven Chen",
                        Email = "steven.chen@soohoobook.com",
                    }
                }
            );
            options.AddSecurityDefinition(
                "Bearer",
                new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.ApiKey,
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Scheme = "Bearer",
                    BearerFormat = "JWT",
                    Description = "JWT Authorization"
                }
            );
            options.AddSecurityDefinition(
                "X-API-KEY",
                new OpenApiSecurityScheme
                {
                    Type = SecuritySchemeType.ApiKey,
                    Name = "X-API-KEY",
                    In = ParameterLocation.Header,
                    Scheme = "X-API-KEY",
                    Description = "internal api key"
                }
            );
            options.AddSecurityRequirement(
                new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer",
                            }
                        },
                        new string[] { }
                    }
                }
            );
            options.AddSecurityRequirement(
                new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "X-API-KEY",
                            }
                        },
                        new string[] { }
                    }
                }
            );
        });
    }
}
