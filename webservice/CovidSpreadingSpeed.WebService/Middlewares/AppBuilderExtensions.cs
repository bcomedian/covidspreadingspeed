using Microsoft.AspNetCore.Builder;

namespace CovidSpreadingSpeed.WebService.Middlewares
{
    public static class AppBuilderExtensions
    {
        public static IApplicationBuilder UseControllersLogging(
            this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<ControllersLoggingMiddleware>();
        }
    }
}
