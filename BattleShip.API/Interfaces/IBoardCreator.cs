using System;
using BattleShip.API.Models;
namespace BattleShip.API.Interfaces
{
    public interface IBoardCreator
    {
        Board CreateBoard(int rows, int columns);
    }
}
