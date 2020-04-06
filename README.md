# Battleship

## The Tasks requirements:

* Create a board
* Add a battleship to the board
* Take an "attack" at a given position, and report back whether the attack resulted in a
hit or a miss
* Return whether the player has lost the game yet (i.e. all battleships are sunk)

#### It could running in local see below for localurl and sample payload  
#### Please go to the unit tests verify all the functionality.
### public endpoints:
 - ```http://battleshipapi.australiaeast.azurecontainer.io```


## Get up and running from the command prompt
* Ensure you've installed .NET Core 3
* Open the command prompt
* Ensure you have git installed
* Run the following git clone: ```git clone git@github.com:sandylib/battleship.git```

## Simple click the ```sln``` could run the project if you have visio studio installed

## Run by using command
* Type ```dotnet restore``` in the command prompt
* Type ```dotnet build``` in the command prompt
* Type ```dont net run``` inside BattleShip.API projects(not the Test project)
* Type ```dotnet test``` (inside the Test project) to run the unit tests.


### example APIs: please looking into the Test project find more test payload


* Create a board
* local url: https://localhost:5001/api/v1/battle/create
* public url: http://battleshipapi.australiaeast.azurecontainer.io/api/v1/battle.create

```sh
{
  "rows": 10,
  "columns": 10
}

```

* Add battleship to the board
* local url: https://localhost:5001/api/v1/battle/place
* public url: http://battleshipapi.australiaeast.azurecontainer.io/api/v1/battle/place
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
* local url: https://localhost:5001/api/v1/battle/attack
* public url: http://battleshipapi.australiaeast.azurecontainer.io/api/v1/battle/attack
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

## Trouble shoot

### project build by using visio studio from mac if you have certificate valid issue, please do below

- first go to ```Go -> Utilities -> KeyChain Access.``` delete the localcetificate

- second run ```dotnet dev-certs https --trust``` will generate new dev trust certs.
