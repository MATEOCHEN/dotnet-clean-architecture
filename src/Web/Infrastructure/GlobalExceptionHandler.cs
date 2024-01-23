using Microsoft.AspNetCore.Diagnostics;

namespace clean_architecture_template.Infrastructure;

public class GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger) : IExceptionHandler
{
    public async ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
    {
        await HandleValidationException(httpContext,exception);
        return true;

    }
    private async Task HandleValidationException(HttpContext httpContext, Exception exception)
    {
        logger.LogError(exception.ToString());
        
        var httpContextResponse = httpContext.Response;
        httpContextResponse.StatusCode = StatusCodes.Status400BadRequest;
        await httpContextResponse.WriteAsJsonAsync(new GeneralApiResponse<object>
        {
            Success = false,
            Message = exception.Message
        });
    }

}
