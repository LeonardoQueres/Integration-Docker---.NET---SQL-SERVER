using FluentAssertions;
using Moq.AutoMock;
using Thunders_Borders.Enums;
using Thunders_Borders.Shared;

namespace Thunders_Tests
{
    public abstract class BaseUseCaseTests<TUseCase, TRequest, TResponse> where TUseCase : class, IUseCase<TRequest, TResponse>
    {
        protected readonly AutoMocker AutoMocker = new();
        protected TUseCase GetSut() => AutoMocker.CreateInstance<TUseCase>();

        protected async Task ActAndAssertSuccess(TRequest request, UseCaseResponseKind useCaseResponseKind, TResponse expectedResponse)
        {
            //Act
            var response = await GetSut().Execute(request);

            //Assert
            AssertSuccess(response, useCaseResponseKind, expectedResponse);
        }

        protected void AssertSuccess(UseCaseResponse<TResponse> response, UseCaseResponseKind useCaseResponseKind, TResponse expectedResponse)
        {
            response.Should().NotBeNull();
            response.Success().Should().BeTrue();
            response.Status.Should().Be(useCaseResponseKind);
            response.Result.Should().BeEquivalentTo(expectedResponse);
            AutoMocker.VerifyAll();
        }

        protected async Task ActAndAssertFail(TRequest request, UseCaseResponseKind useCaseResponseKind, ErrorMessage errorMessage)
        {
            //Act
            var response = await GetSut().Execute(request);

            //Assert
            response.Should().NotBeNull();
            response.Success().Should().BeFalse();
            response.Status.Should().Be(useCaseResponseKind);
            response.Errors.Should().Contain(x => x == errorMessage);
            AutoMocker.VerifyAll();
        }
    }

    public abstract class BaseUseCaseTests<TUseCase, TResponse> where TUseCase : class, IUseCase<TResponse>
    {
        protected readonly AutoMocker AutoMocker = new();
        protected TUseCase GetSut() => AutoMocker.CreateInstance<TUseCase>();

        protected async Task ActAndAssertSuccess(UseCaseResponseKind useCaseResponseKind, TResponse expectedResponse)
        {
            //Act
            var response = await GetSut().Execute();

            //Assert
            AssertSuccess(response, useCaseResponseKind, expectedResponse);
        }

        protected void AssertSuccess(UseCaseResponse<TResponse> response, UseCaseResponseKind useCaseResponseKind, TResponse expectedResponse)
        {
            response.Should().NotBeNull();
            response.Success().Should().BeTrue();
            response.Status.Should().Be(useCaseResponseKind);
            response.Result.Should().BeEquivalentTo(expectedResponse);
            AutoMocker.VerifyAll();
        }

        protected async Task ActAndAssertFail(UseCaseResponseKind useCaseResponseKind, ErrorMessage errorMessage)
        {
            //Act
            var response = await GetSut().Execute();

            //Assert
            response.Should().NotBeNull();
            response.Success().Should().BeFalse();
            response.Status.Should().Be(useCaseResponseKind);
            response.Errors.Should().Contain(x => x == errorMessage);
            AutoMocker.VerifyAll();
        }
    }
}
