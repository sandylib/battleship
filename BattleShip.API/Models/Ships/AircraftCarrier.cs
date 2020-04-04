using System;
using BattleShip.API.Enums;
namespace BattleShip.API.Models.Ships
{
    public class AircraftCarrier : Ship
    {
        public AircraftCarrier()
        {
            Size = 5;
            ShipType = ShipType.AircraftCarrier;
        }
    }
}
