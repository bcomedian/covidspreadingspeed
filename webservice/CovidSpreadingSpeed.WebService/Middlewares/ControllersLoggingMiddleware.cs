using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CovidSpreadingSpeed.WebService.Middlewares
{
    public class ControllersLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ControllersLoggingMiddleware(RequestDelegate next, ILoggerFactory loggerFactory)
        {
            _next = next;
            _logger = loggerFactory.CreateLogger<ControllersLoggingMiddleware>();
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            _logger.LogInformation($"Endpoint {httpContext.Request.Path} is launched.");
            
            await _next.Invoke(httpContext);
            
            _logger.LogInformation($"Endpoint {httpContext.Request.Path} returned " +
                $"{httpContext.Response.StatusCode} with {httpContext.Response.ContentLength ?? 0} length");
        }
    }
}
