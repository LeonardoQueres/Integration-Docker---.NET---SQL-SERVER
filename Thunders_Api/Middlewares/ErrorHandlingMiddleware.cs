using FluentValidation;
using System.Net;
using System.Text.Json;
using Thunders_Borders.Shared;
using Thunders_Borders.Shared.Exceptions;
using Thunders_Borders.Shared.Extensions;

namespace Thunders_Api.Middlewares
{
    public class ErrorHandlingMiddleware(RequestDelegate next)
    {
        public async Task Invoke(HttpContext context, ILogger<ErrorHandlingMiddleware> logger)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex, logger);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, ILogger<ErrorHandlingMiddleware> logger)
        {
            var (code, errorMessage, errors) = exception switch
            {
                RepositoryException ex => (ex.StatusCode, ex.Message, ex.Errors),
                ValidationException e => (HttpStatusCode.BadRequest, ErrorCodes.ValidationError, e.ToErrorMessage()),
                _ => (HttpStatusCode.InternalServerError, "Internal Server Error", new ErrorMessage[] { new(ErrorCodes.InternalServerError, "Internal Server Error") })
            };

            if (errorMessage is not null)
                logger.LogError(exception, "{@ErrorMessage} {@Errors}", errorMessage, errors);

            if (HttpStatusCode.BadGateway == code)
            {
                errors ??= Array.Empty<ErrorMessage>();
                errors = errors.Append(ErrorMessages.ErroCommunicacaoComServico);
            }

            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)code;

            return context.Response.WriteAsync(JsonSerializer.Serialize(errors, JsonExtensions.DefaultSerializerOptions));
        }
    }
}
