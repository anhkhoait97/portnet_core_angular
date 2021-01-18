using Microsoft.AspNetCore.Builder;
using PortNet.Service.Helpers;

namespace Web.BackendServer.Extentions
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseErrorWrapping(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorWrappingMiddleware>();
        }
    }
}