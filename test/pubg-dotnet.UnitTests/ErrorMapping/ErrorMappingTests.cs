using AutoFixture;
using FluentAssertions;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure;
using Pubg.Net.Models.Errors;
using System.Linq;
using Xunit;

namespace Pubg.Net.UnitTests.ErrorMapping
{
    public class ErrorMappingTests
    {
        [Fact]
        public void ErrorMapper_Can_MapError()
        {
            var fixture = new Fixture();
            var error = fixture.Create<PubgError>();
            var errorJson = JsonConvert.SerializeObject(error);

            string json = $@"{{
                ""data"": [],
                ""included"" : [],
                ""errors"": [
                    {errorJson}
                ]
            }}";

            var mappedErrors = ErrorMapper.MapErrors(json);

            mappedErrors.Should().NotBeNullOrEmpty();

            var mappedError = mappedErrors.First();

            mappedError.Should().BeEquivalentTo(error);
        }

        [Fact]
        public void ErrorMapper_Can_MapManyErrors()
        {
            var fixture = new Fixture();
            var errors = fixture.CreateMany<PubgError>();
            var errorJson = JsonConvert.SerializeObject(errors);

            string json = $@"{{
                ""data"": [],
                ""included"" : [],
                ""errors"": {errorJson}
            }}";

            var mappedErrors = ErrorMapper.MapErrors(json);

            mappedErrors.Should().NotBeNullOrEmpty();

            Assert.All(mappedErrors, error => errors.Contains(error));
        }
    }
}
