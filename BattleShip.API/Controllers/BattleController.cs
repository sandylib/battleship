using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BattleShip.API.Enums;
using BattleShip.API.Implementations;
using BattleShip.API.Interfaces;
using BattleShip.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
namespace BattleShip.API.Controllers
{
    [Route("api/v1/battle")]
    [ApiController]
    public class BattleController :ControllerBase
    {
        [Route("create")]
        [HttpPost]
        public ActionResult<IBoardCreator> CreateBoard([FromBody] BoardParameters newBoard)
        {
            var boardCreator = new BoardCreator();
            var board = boardCreator.CreateBoard(newBoard.Rows, newBoard.Columns);
            return Ok("new board create  row length  is: " + board.Rows + "columns is: " + board.Columns );
        }


        [Route("place")]
        [HttpPost]
        public ActionResult PlaceShip([FromBody] PlaceShipParameters body)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(body.boardRows, body.boardColumns);

                //then create a ship
                var shipCreator = new ShipCreator();
                var ship = shipCreator.CreateShip(body.shipType);


                //now place the ship on the board
                var shipPlacer = new ShipPlacer();
                shipPlacer.AddShipToBoard(ship, board, body.placementRow, body.placementColumn);

                return Ok("Place ship on the board");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


        [Route("attack")]
        [HttpPost]
        public ActionResult Attacker([FromBody] AttackParameters attack)
        {
            try
            {
                var boardCreator = new BoardCreator();
                var board = boardCreator.CreateBoard(attack.boardRows, attack.boardColumns);

                //then create a ship
                var shipCreator = new ShipCreator();
                var ship = shipCreator.CreateShip(attack.shipType);

                //place the ship on the board
                var shipPlacer = new ShipPlacer();
                shipPlacer.AddShipToBoard(ship, board, attack.placementRow, attack.placementColumn);

             
                //now attack the ship at the given position
                var attacker = new Attacker();
                var result = attacker.Attack(board, attack.attackRow, attack.attackColumn);
                return Ok(result == AttackStatus.Hit ? "Hit" : "Miss");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            };
        }
    }
}
