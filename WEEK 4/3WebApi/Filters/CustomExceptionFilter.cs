// ----------------------------
// File: Filters/CustomExceptionFilter.cs
// ----------------------------
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.IO;

namespace FirstWebApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string errorMessage = $"[{DateTime.Now}] {context.Exception.Message}{Environment.NewLine}";
            File.AppendAllText("Logs.txt", errorMessage);

            context.Result = new ObjectResult("An unexpected error occurred. Please try again later.")
            {
                StatusCode = 500
            };
        }
    }
}
