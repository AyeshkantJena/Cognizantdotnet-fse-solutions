using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebApiHandson3.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string error = $"[{DateTime.Now}] ERROR: {context.Exception.Message}";

            // Log to a local file
            File.AppendAllText("exception_log.txt", error + Environment.NewLine);

            // Return a 500 Internal Server Error response
            context.Result = new ObjectResult("Internal Server Error occurred.")
            {
                StatusCode = 500
            };
        }
    }
}
