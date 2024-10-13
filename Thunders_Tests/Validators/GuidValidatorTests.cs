using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thunders_Borders.Shared;
using Thunders_Borders.Validators;
using Xunit;

namespace Thunders_Tests.Validators
{
    public class GuidValidatorTests
    {
        private readonly ErrorMessage errorMessage = new("00.00", "Error message");
        private readonly GuidValidator validator;

        public GuidValidatorTests() => validator = new(errorMessage);

        [Fact]
        public void Validate_WhenGuidIsValid_IsValid()
        {
            var result = validator.Validate(Guid.NewGuid());
            result.IsValid.Should().BeTrue();
        }

        [Fact]
        public void Validate_WhenGuidIsEmpty_IsInvalid() => ActAndAssertInvalid(Guid.Empty);

        private void ActAndAssertInvalid(Guid guid)
        {
            //Act
            var result = validator.Validate(guid);

            //Assert
            result.IsValid.Should().BeFalse();
            result.Errors.Should().Contain(t => t.ErrorCode == errorMessage.Code && t.ErrorMessage == errorMessage.Message);
        }
    }
}
