using System;
using BattleShip.API.Enums;
using BattleShip.API.Interfaces;
using BattleShip.API.Models;
using BattleShip.API.Models.Ships;

namespace BattleShip.API.Implementations
{
    public class ShipCreator: IShipCreator
    {
        public Ship CreateShip(ShipType shipType)
        {
            try
            {
                switch (shipType)
                {
                    case ShipType.AircraftCarrier:
                        return new AircraftCarrier();

                    case ShipType.Destroyer:
                        return new Destroyer();

                    default:
                        return new AircraftCarrier();
                }
            }
            catch (System.Exception ex)
            {
                throw new Exception($"Could not create ship : {ex.Message}");
            }
        }
    }
}
