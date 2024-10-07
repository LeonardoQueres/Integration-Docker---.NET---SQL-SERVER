using Microsoft.AspNetCore.Mvc;
using Thunders_Borders.Shared;

namespace Thunders_Api.Extensions
{
    public static class InvalidModelStateResponseFactory
    {
        public static IActionResult CreateResponse(ActionContext context)
        {
            var errors = context.ModelState.SelectMany(modelState =>
            {
                return modelState.Value!.Errors.Select(err
                    => new ErrorMessage(ErrorCodes.ValidationError, $"{modelState.Key} - {err.ErrorMessage}"));
            });

            return new BadRequestObjectResult(errors);
        }
    }
}
