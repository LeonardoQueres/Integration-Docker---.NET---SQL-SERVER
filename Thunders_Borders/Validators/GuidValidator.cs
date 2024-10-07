using FluentValidation;
using Thunders_Borders.Shared;
using Thunders_Borders.Shared.Extensions;

namespace Thunders_Borders.Validators
{
    public class GuidValidator : AbstractValidator<Guid>
    {
        public GuidValidator(ErrorMessage errorMessage)
        {
            RuleFor(t => t)
                .NotEmpty().WithErrorMessage(errorMessage);
        }
    }
}
