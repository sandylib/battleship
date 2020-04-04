using System;
using BattleShip.API.Enums;
using BattleShip.API.Models;

namespace BattleShip.API.Interfaces
{
    public class ShipPlacer : IShipPlacer
    {
        public void AddShipToBoard(Ship ship, Board board, int row, int column)
        {
            Validate(ship, board, row, column);

            for (int i = 0; i < ship.Size; i++)
            {
                //for each ship coordinate, update cell status to occupied
                board.BoardCellStatuses[row, column + i] = BoardCellStatus.Occupied;

                //update the number of cells that are occupied.
                //I use this to compare against number of hits as a simple way to
                //determine if the game is lost
                board.OccupationCount++;
            }
        }
        private void Validate(Ship ship, Board board, int row, int column)
        {
            var errorMessage = "Ship's placement position is out of bounds";

            //validate if starting positions in bounds of the board
            if (row > board.Rows)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }

            if (column > board.Columns)
            {
                throw new IndexOutOfRangeException(errorMessage);
            }

            for (int c = 0; c < ship.Size; c++)
            {
                if (column + c > board.Columns)
                {
                    throw new IndexOutOfRangeException(errorMessage);
                }
            }
        }
    }
}
