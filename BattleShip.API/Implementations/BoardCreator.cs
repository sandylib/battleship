using System;
using BattleShip.API.Enums;
using BattleShip.API.Interfaces;
using BattleShip.API.Models;

namespace BattleShip.API.Implementations
{
    public class BoardCreator : IBoardCreator
    {
      
       public Board CreateBoard(int rows, int columns)
        {
            try
            {
                //build up the board and set all cells to unoccupied
                BoardCellStatus[,] statusArray = new BoardCellStatus[rows, columns];
                for (int row = 0; row < rows; row++)
                {
                    for (int column = 0; column < columns; column++)
                    {
                        statusArray[row, column] = BoardCellStatus.Unoccupied;
                    }
                }

                //return the board
                return new Board
                {
                    BoardCellStatuses = statusArray,
                    Rows = rows,
                    Columns = columns
                };
            }
            catch (Exception ex)
            {
                throw new Exception($"Error while creating board : {ex.Message}");
            }
        }
    }
}
