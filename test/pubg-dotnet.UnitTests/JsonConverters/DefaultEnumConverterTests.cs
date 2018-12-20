using FluentAssertions;
using JsonApiSerializer;
using Newtonsoft.Json;
using Pubg.Net.Infrastructure.Attributes;
using Pubg.Net.Infrastructure.JsonConverters;
using System;
using System.Collections.Generic;
using Xunit;

namespace Pubg.Net.UnitTests.JsonConverters
{
    public class DefaultEnumConverterTests
    {
        public class TestArticle
        {
            [JsonProperty]
            public int Id { get; set; }

            [JsonProperty]
            public TestEnum TestEnum { get; set; }
        }
        
        [JsonConverter(typeof(DefaultValueStringEnumConverter))]
        public enum TestEnum
        {
          [DefaultEnumMember]
          Default = 0,
          NonDefault = 1
        }

        string jsonApiLiteral =
            @"{
                ""data"": 
                {
                  ""type"": ""TestArticle"",
                  ""id"": ""1"",
                  ""attributes"": 
                  {
                    ""testEnum"": ""%%ENUM_VALUE%%"",
                  }
                }
            }";

        [Fact]
        public void DefaultValueStringEnumConverter_Can_ConvertToValue()
        {
            var value = TestEnum.NonDefault;
            var valueJson = jsonApiLiteral.Replace("%%ENUM_VALUE%%", value.ToString());
            var obj = JsonConvert.DeserializeObject<TestArticle>(valueJson);
            
            obj.TestEnum.Should().Equals(value);
        }
        
        [Fact]
        public void DefaultValueStringEnumConverter_Can_ConvertFromEmptyString()
        {
            var valueJson = jsonApiLiteral.Replace("%%ENUM_VALUE%%", "");
            var obj = JsonConvert.DeserializeObject<TestArticle>(valueJson);
            
            obj.TestEnum.Should().Equals(value);
        }
        
        [Fact]
        public void DefaultValueStringEnumConverter_Can_ConvertFromUnknownValue()
        {
            var valueJson = jsonApiLiteral.Replace("%%ENUM_VALUE%%", "RandomValue");
            var obj = JsonConvert.DeserializeObject<TestArticle>(valueJson);
            
            obj.TestEnum.Should().Equals(value);  
        }
    }
}
