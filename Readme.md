# Treehouse Defense

Treehouse Defense is a tower defense game in the form of a console application.  
It was built using teamtreehouse.com lessons to help learn the C# programming language.

## Getting Started

### Prerequisites

Treehouse Defense requires Microsoft's .NET Core SDK installed in order to build and run the application. 

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
2. Through the game's level files

### The Console

* When the application runs the user will be prompted to select a level.  
* The game will then be played through from start to finish in 1 turn.

### Game level files
To place towers on the game's map the player will need to update the level files and update the code in the Tower section. Only the tower code needs be updated.

* Before running the application in the terminal open the `Level1.cs` file.   
* Find the Tower code commented as `//Select your Towers`
* The following towers can be placed by entering the tower name and coordinates on the map.

| Tower Name  | Description |
| ----------  | ----------- |
|   Tower     | Default     |
| PowerTower  | 2x Damage   |
| SniperTower | 2x Hit Range|


## Version

1.1.0 