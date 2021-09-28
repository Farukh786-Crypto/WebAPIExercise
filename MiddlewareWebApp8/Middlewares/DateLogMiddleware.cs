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
    public class DateLogMiddleware
    {
        private readonly RequestDelegate _next;

        public DateLogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {
            Console.WriteLine("Access time: "+DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class DateLogMiddlewareExtensions
    {
        public static IApplicationBuilder UseDateLogMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<DateLogMiddleware>();
        }
    }
}
