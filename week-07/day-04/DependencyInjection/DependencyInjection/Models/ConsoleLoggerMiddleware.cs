using System;
using System.Threading.Tasks;
using DependencyInjection.Interfaces;
using Microsoft.AspNetCore.Http;

namespace DependencyInjection.Models
{
    class ConsoleLoggerMiddleware : IMiddleware
    {
        private Printer printer;
        private IColor Color;

        public ConsoleLoggerMiddleware(Printer printer, IColor color)
        {
            this.printer = printer;
            this.Color = color;
        }

        Task IMiddleware.InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("Hi from the middleware");
            Color.PrintColor();
            return next(context);
        }
    }
}
