using System;
using BattleShip.API.Enums;
namespace BattleShip.API.Models
{
    public abstract class Ship
    {
        public ShipType ShipType { get; set; }
        public int Size { get; set; }
    }
}
