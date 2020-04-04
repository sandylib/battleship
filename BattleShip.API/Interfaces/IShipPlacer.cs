using System;
using BattleShip.API.Models;
namespace BattleShip.API.Interfaces
{
    public interface IShipPlacer
    {
        void AddShipToBoard(Ship ship, Board board, int row, int column);
    }
}
