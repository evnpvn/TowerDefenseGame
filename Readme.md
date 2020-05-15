# Tower Defense Game

This game is a simple version of the standard tower defense game built in the form of a console application.  
It was built to help learn the C# programming language.

## Getting Started

### Prerequisites

Tower Defense requires Microsoft's .NET Core SDK installed in order to build and run the application. 

https://dotnet.microsoft.com/download

### Installing

After installing .NET Core run the following command in the terminal to install the required files:

```
$ dotnet restore
```

If the previous command results in error, the C# project file may need to be recreated using the following command.   
```
$ dotnet new console
```
New console will by default create a new hello world console application and related files. Delete the HelloWorld.cs file and re-run the `dotnet restore` command.

### Running

To build and run the game use the following command in the terminal:

```
$ dotnet run
```

## How to Play

Players interact with the game in 2 ways:
1. Directly in the console
2. Through the game's Playlevel files

#### The Console

* When the application runs the user will be introduced to the game and prompted to select a level
* Once selected he game will then be played through from start to finish without any further interaction

#### Playlevel files
To place towers on the game's map the player will need to update the coordinate values of each tower. Only the tower code in the PlayLevel files needs be updated.

* Before running the application in the terminal open the `PlayLevelOne.cs` file.   
* Find the code commented as `//Place your towers//`

## Invaders
The following invaders will move down the path. If an invader gets to the end of the path you lose. But if all invaders are killed you win.

* When the game starts all Invaders will begin at the same time at the start of the path 
* All

| Invader Name         | Description                                                 |
| -------------------  | ----------------------------------------------------------  |
| Basic Inavder        | 2 health points, moves 1 square/turn                        |
| Fast Invader         | Moves 2 squares/turn                                        |
| Shielded Invader     | 50% change no damage per attack                             |
| Strong Invader       | 4 health points                                             |
| Ressurecting Invader | A basic invader that when killed returns as a strong invader|

## Towers
The following towers can be placed by entering their coordinates on the PlayLevel files. 

* All towers will have a chance to shoot once per turn  
* All towers have a 75% chance to hitting their target if it is in range.


| Tower Name   | Description                        |
| ----------   | ---------------------------------- |
| Basic Tower  | 1 damage, 1 square hit range       |
| Power Tower  | 2x damage                          |
| Sniper Tower | 2x hit range (available in level 2)|
  


## Version

1.1.0 
