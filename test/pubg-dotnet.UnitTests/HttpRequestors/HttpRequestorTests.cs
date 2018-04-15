using AutoFixture;
using FluentAssertions;
using Newtonsoft.Json;
using Pubg.Net.Exceptions;
using Pubg.Net.Infrastructure;
using Pubg.Net.Models.Errors;
using RichardSzalay.MockHttp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using Xunit;

namespace Pubg.Net.UnitTests.HttpRequestors
{
    public class HttpRequestorTests
    {
        [Fact]
        public void HttpRequestor_Takes_Timeout_From_Configuration()
        {
            var timeout = TimeSpan.FromMinutes(5);
            PubgApiConfiguration.SetHttpTimeout(timeout);

            var actualTimeout = HttpRequestor.HttpClient.Timeout;

            actualTimeout.Should().Equals(timeout);
        }

        [Fact]
        public void HttpRequestor_Attaches_ApiKey_To_Request()
        {
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.Fallback.Throw(new InvalidOperationException("No token attached to request"));

            var apiToken = "token";

            mockHttp.Expect(HttpMethod.Get, "*").WithHeaders("Authorization", $"Bearer {apiToken}").Respond("application/json", "test string");

            MockHttpClient(mockHttp);

            var result = HttpRequestor.GetString("http://www.random.url", apiToken);
        }

        [Fact]
        public void HttpRequestor_Requests_GzippedContent()
        {
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.Fallback.Throw(new InvalidOperationException("No gzip header was found"));

            mockHttp.Expect(HttpMethod.Get, "*").WithHeaders("Accept-Encoding", "gzip").Respond("application/json", "test string");

            MockHttpClient(mockHttp);

            var result = HttpRequestor.GetString("http://www.random.url", "token");
        }

        [Fact]
        public void HttpRequestor_Requests_CorrectMediaType()
        {
            var mockHttp = new MockHttpMessageHandler();
            mockHttp.Fallback.Throw(new InvalidOperationException("No gzip header was found"));

            mockHttp.Expect(HttpMethod.Get, "*").WithHeaders("Accept", "application/vnd.api+json").Respond("application/json", "test string");

            MockHttpClient(mockHttp);

            var result = HttpRequestor.GetString("http://www.random.url", "token");
        }

        [Theory]
        [InlineData(HttpStatusCode.NotFound, typeof(PubgNotFoundException))]
        [InlineData(HttpStatusCode.UnsupportedMediaType, typeof(PubgContentTypeException))]
        [InlineData(HttpStatusCode.Unauthorized, typeof(PubgUnauthorizedException))]
        [InlineData((HttpStatusCode) 429, typeof(PubgTooManyRequestsException))]
        [InlineData(HttpStatusCode.BadRequest, typeof(PubgException))]
        public void HttpRequestor_Throws_CorrectErrorForHttpStatus(HttpStatusCode statusCode, Type errorType)
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp
                .When("*")
                .Respond(statusCode, new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("X-RateLimit-Reset", "1000") }, new StringContent("{\"errors\" : []}"));

            MockHttpClient(mockHttp);

            Assert.Throws(errorType, () => HttpRequestor.GetString("http://random.url"));
        }

        [Theory]
        [InlineData(HttpStatusCode.NotFound)]
        [InlineData(HttpStatusCode.UnsupportedMediaType)]
        [InlineData(HttpStatusCode.Unauthorized)]
        [InlineData((HttpStatusCode)429)]
        [InlineData(HttpStatusCode.BadRequest)]
        public void PubgErrors_Have_Correct_HttpStatus(HttpStatusCode statusCode)
        {
            var mockHttp = new MockHttpMessageHandler();

            mockHttp
                .When("*")
                .Respond(statusCode, new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("X-RateLimit-Reset", "1000") }, new StringContent("{\"errors\" : []}"));

            MockHttpClient(mockHttp);

            try
            {
                HttpRequestor.GetString("http://random.url");
            }
            catch(PubgException ex)
            {
                ex.HttpStatusCode.Should().Equals(statusCode);
            }
        }

        [Fact]
        public void PubgErrors_Have_ApiErrors_MappedCorrectly()
        {
            var mockHttp = new MockHttpMessageHandler();
            var errors = new Fixture().CreateMany<PubgError>();
            var errorsJson = JsonConvert.SerializeObject(errors);

            mockHttp
                .When("*")
                .Respond(HttpStatusCode.BadRequest, "application/json", $"{{ \"errors\": {errorsJson} }}");

            MockHttpClient(mockHttp);

            try
            {
                HttpRequestor.GetString("http://random.url");
            }
            catch (PubgException ex)
            {
                ex.Errors.Count().Should().Equals(errors.Count());
                Assert.All(ex.Errors, err => errors.Contains(err));
            }
        }

        private void MockHttpClient(MockHttpMessageHandler handler)
        {
            typeof(HttpRequestor).GetProperty(nameof(HttpRequestor.HttpClient), BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, handler.ToHttpClient());
        }
    }
}
