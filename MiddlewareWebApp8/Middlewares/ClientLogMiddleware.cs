using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareWebApp8.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ClientLogMiddleware
    {
        private readonly RequestDelegate _next;

        public ClientLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            var ipAddress = httpContext.Connection.RemoteIpAddress.ToString();
            var url =httpContext.Request.Path;
            Console.WriteLine("Url:"+url);
            Console.WriteLine("IpAddresss:"+ipAddress);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ClientLogMiddlewareExtensions
    {
        public static IApplicationBuilder UseClientLogMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ClientLogMiddleware>();
        }
    }
}
