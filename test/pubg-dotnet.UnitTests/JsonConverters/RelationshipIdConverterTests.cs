using FluentAssertions;
using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure.JsonConverters;
using System;
using System.Collections.Generic;
using Xunit;

namespace Pubg.Net.UnitTests.JsonConverters
{
    public class RelationshipIdConverterTests
    {
        public class TestArticle
        {
            [JsonProperty]
            public int Id { get; set; }

            [JsonProperty]
            public string Title { get; set; }

            [JsonProperty]
            public string Body { get; set; }

            [JsonProperty]
            public DateTime Created { get; set; }

            [JsonProperty]
            public DateTime Updated { get; set; }

            [JsonProperty("author")]
            [JsonConverter(typeof(RelationshipIdConverter))]
            public IEnumerable<string> AuthorIds { get; set; }
        }

        string jsonApiLiteral =
            @"{
                ""data"": 
                {
                  ""type"": ""TestArticle"",
                  ""id"": ""1"",
                  ""attributes"": 
                  {
                    ""title"": ""JSON API paints my bikeshed!"",
                    ""body"": ""The shortest article. Ever."",
                    ""created"": ""2015-05-22T14:56:29.000Z"",
                    ""updated"": ""2015-05-22T14:56:28.000Z""
                  },
                  ""relationships"": 
                   {
                      ""author"": 
                      {
                        ""data"": 
                        [ 
                          {""id"": 42, ""type"": ""people""},
                          {""id"": 43, ""type"": ""people""},
                          {""id"": 44, ""type"": ""people""},
                          {""id"": 45, ""type"": ""people""}
                        ]
                      }
                   }
                }
            }";

        [Fact]
        public void RelationshipIdConverter_Converts_FromJsonApiFormat()
        {
            TestArticle testArticle = JsonConvert.DeserializeObject<TestArticle>(jsonApiLiteral, new JsonApiSerializerSettings());

            testArticle.Id.Should().Equals(1);
            testArticle.Title.Should().Equals("JSON API paints my bikeshed!");
            testArticle.Body.Should().Equals("The shortest article. Ever.");
            testArticle.Created.Should().Equals(Convert.ToDateTime("2015-05-22T14:56:29.000Z"));
            testArticle.Updated.Should().Equals(Convert.ToDateTime("2015-05-22T14:56:28.000Z"));
            testArticle.AuthorIds.Should().NotBeNullOrEmpty();
            testArticle.AuthorIds.Should().Contain(new [] { "42", "43", "44", "45" });
        }

        [Fact]
        public void RelationshipIdConverter_Converts_FromJsonApiFormat_MultipleTimes()
        {
            TestArticle testArticle = JsonConvert.DeserializeObject<TestArticle>(jsonApiLiteral, new JsonApiSerializerSettings());

            var reserializedArticle = JsonConvert.SerializeObject(testArticle);
            var deserializedArticle = JsonConvert.DeserializeObject<TestArticle>(reserializedArticle);

            deserializedArticle.Id.Should().Equals(1);
            deserializedArticle.Title.Should().Equals("JSON API paints my bikeshed!");
            deserializedArticle.Body.Should().Equals("The shortest article. Ever.");
            deserializedArticle.Created.Should().Equals(Convert.ToDateTime("2015-05-22T14:56:29.000Z"));
            deserializedArticle.Updated.Should().Equals(Convert.ToDateTime("2015-05-22T14:56:28.000Z"));
            deserializedArticle.AuthorIds.Should().NotBeNullOrEmpty();
            deserializedArticle.AuthorIds.Should().Contain(new[] { "42", "43", "44", "45" });
        }

        [Fact]
        public void RelationshipIdConverter_Converts_FromApplicationJson()
        {
            var baseArticle = new TestArticle
            {
                Id = 1,
                Title = "adsd",
                Body = "asda",
                Created = Convert.ToDateTime("2015-05-22T14:56:29.000Z"),
                Updated = Convert.ToDateTime("2015-05-22T14:56:29.000Z"),
                AuthorIds = new[] { "11", "12" }
            };

            var serializedArticle = JsonConvert.SerializeObject(baseArticle);

            var deSerialzedArticle = JsonConvert.DeserializeObject<TestArticle>(serializedArticle);

            deSerialzedArticle.Id.Should().Equals(baseArticle.Id);
            deSerialzedArticle.Title.Should().Equals(baseArticle.Title);
            deSerialzedArticle.Body.Should().Equals(baseArticle.Body);
            deSerialzedArticle.Created.Should().Equals(baseArticle.Created);
            deSerialzedArticle.Updated.Should().Equals(baseArticle.Updated);
            deSerialzedArticle.AuthorIds.Should().NotBeNullOrEmpty();
            deSerialzedArticle.AuthorIds.Should().Contain(baseArticle.AuthorIds);
        }
    }
}
