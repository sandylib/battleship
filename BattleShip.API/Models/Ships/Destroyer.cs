using System;
using BattleShip.API.Enums;
namespace BattleShip.API.Models.Ships
{
    public class Destroyer : Ship
    {
        public Destroyer()
        {
            Size = 2;
            ShipType = ShipType.Destroyer;
        }
    }
}
