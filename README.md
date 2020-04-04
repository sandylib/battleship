# Battleship

## The Tasks requirements:

* Create a board
* Add a battleship to the board
* Take an "attack" at a given position, and report back whether the attack resulted in a
hit or a miss
* Return whether the player has lost the game yet (i.e. all battleships are sunk)

No UI was developed. The unit tests verify all the functionality.

## Get up and running from the command prompt
* Ensure you've installed .NET Core 3
* Open the command prompt
* Ensure you have git installed
* Run the following git clone: ```git clone git@github.com:sandylib/battleship.git```
* Type ```dotnet restore``` in the command prompt
* Type ```dotnet build``` in the command prompt
* Type ```dotnet test``` to run the unit tests.


### curl command

* Create a board
* url: https://localhost:5001/api/v1/battle/create

```sh
{
  "rows": 10,
  "columns": 10
}

```

* Add battleship to the board
* url: https://localhost:5001/api/v1/battle/place
```sh
{
  "boardRows": 10,
  "boardColumns": 10,
  "placementRow": 0,
  "placementColumn": 0,
  "shipType":1
  
}
```


* Take an "attack", expecting payload
https://localhost:5001/api/v1/battle/attack
```sh

{
	"boardRows": 10,
	"boardColumns": 10,
	"placementRow": 0, 
	"placementColumn": 0,
	"attackRow": 0, 
	"attackColumn": 0, 
	"shipType": 0,
	"boardCellStatus": 2
}
```
