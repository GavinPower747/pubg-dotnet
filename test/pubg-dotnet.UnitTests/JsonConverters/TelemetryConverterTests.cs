using AutoFixture;
using AutoFixture.Kernel;
using FluentAssertions;
using Newtonsoft.Json;
using Pubg.Net.Models.Telemetry.Events;
using System;
using Xunit;

namespace Pubg.Net.UnitTests.JsonConverters
{

    public class TelemetryConverterTests
    {
        [Theory]
        [InlineData(typeof(LogCarePackageLand))]
        [InlineData(typeof(LogCarePackageSpawn))]
        [InlineData(typeof(LogGameStatePeriodic))]
        [InlineData(typeof(LogItemAttach))]
        [InlineData(typeof(LogItemDetach))]
        [InlineData(typeof(LogItemDrop))]
        [InlineData(typeof(LogItemEquip))]
        [InlineData(typeof(LogItemPickup))]
        [InlineData(typeof(LogItemUnequip))]
        [InlineData(typeof(LogItemUse))]
        [InlineData(typeof(LogMatchDefinition))]
        [InlineData(typeof(LogMatchEnd))]
        [InlineData(typeof(LogMatchStart))]
        [InlineData(typeof(LogPlayerAttack))]
        [InlineData(typeof(LogPlayerCreate))]
        [InlineData(typeof(LogPlayerKill))]
        [InlineData(typeof(LogPlayerLogin))]
        [InlineData(typeof(LogPlayerLogout))]
        [InlineData(typeof(LogPlayerPosition))]
        [InlineData(typeof(LogPlayerTakeDamage))]
        [InlineData(typeof(LogVehicleDestroy))]
        [InlineData(typeof(LogVehicleLeave))]
        [InlineData(typeof(LogVehicleRide))]
        [InlineData(typeof(LogArmorDestroy))]
        [InlineData(typeof(LogSwimStart))]
        [InlineData(typeof(LogSwimEnd))]
        [InlineData(typeof(LogWheelDestroy))]
        [InlineData(typeof(LogPlayerMakeGroggy))]
        [InlineData(typeof(LogPlayerRevive))]
        [InlineData(typeof(LogHeal))]
        [InlineData(typeof(LogItemPickupFromCarePackage))]
        [InlineData(typeof(LogItemPickupFromLootBox))]
        [InlineData(typeof(LogObjectDestroy))]
        [InlineData(typeof(LogParachuteLanding))]
        [InlineData(typeof(LogRedZoneEnded))]
        [InlineData(typeof(LogVaultStart))]
        [InlineData(typeof(LogWeaponFireCount))]
        public void Can_Convert_All_TelemeteryEvents(Type eventType)
        {
            var fixture = new Fixture();
            var testEvent = (PubgTelemetryEvent) new SpecimenContext(fixture).Resolve(eventType);
            testEvent.Type = eventType.Name;

            var json = JsonConvert.SerializeObject(testEvent);

            var deserializedObject = JsonConvert.DeserializeObject<PubgTelemetryEvent>(json);

            Assert.Equal(eventType, deserializedObject.GetType());

            deserializedObject.Should().BeEquivalentTo(testEvent);
        }
        
        [Fact]
        public void UnknownEvent_Returns_UnknownEventObject_WithTypeProperty()
        {
            var testEvent = new { _T = "RandomString", TestProp = "TestProp" };

            var json = JsonConvert.SerializeObject(testEvent);

            var deserializedObject = JsonConvert.DeserializeObject<PubgTelemetryEvent>(json);

            Assert.Equal(typeof(UnknownTelemetryEvent), deserializedObject.GetType());

            deserializedObject.As<UnknownTelemetryEvent>().RawContent.Should().Equals(deserializedObject);
        }

        [Fact]
        public void UnknownEvent_Returns_UnknownEventObject_WithoutTypeProperty()
        {
            var testEvent = new { TestProp = "TestProp" };

            var json = JsonConvert.SerializeObject(testEvent);

            var deserializedObject = JsonConvert.DeserializeObject<PubgTelemetryEvent>(json);

            Assert.Equal(typeof(UnknownTelemetryEvent), deserializedObject.GetType());

            deserializedObject.As<UnknownTelemetryEvent>().RawContent.Should().Equals(deserializedObject);
        }
    }
}
