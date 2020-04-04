using System;
using BattleShip.API.Enums;
using BattleShip.API.Implementations;
using Xunit;

namespace BattleShip.Test
{
    public class ShipTests
    {
        [Theory]
        [InlineData(ShipType.AircraftCarrier)]
        public void ShouldReturnShip_WhenShipCreated(ShipType shipType)
        {
            //arrange
            var shipCreator = new ShipCreator();

            //act
            var ship = shipCreator.CreateShip(shipType);

            //assert
            Assert.NotNull(ship);
        }
    }
}
