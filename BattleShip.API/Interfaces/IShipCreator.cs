using System;
using BattleShip.API.Models;
using BattleShip.API.Enums;
namespace BattleShip.API.Interfaces
{
    public interface IShipCreator
    {
        Ship CreateShip(ShipType shipType);
    }
}
