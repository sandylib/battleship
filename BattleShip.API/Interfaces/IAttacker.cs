using System;
using BattleShip.API.Enums;
using BattleShip.API.Models;

namespace BattleShip.API.Interfaces
{
    public interface IAttacker
    {
        AttackStatus Attack(Board board, int row, int column);
    }
}
