using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using MathGame;





//Variables
string name = "";
DateTime date = DateTime.Now;
string option = "";

//List
var game = new GameEngine();

//Display menu and user name's input
Console.WriteLine("What is your name?");
name = Console.ReadLine();

do
{


    Console.WriteLine($@"Welcome to the math game {name}, today is {date.DayOfWeek}
Please select one of the following games option:
A - Addition 
S - Substraction 
M - Multiplication
D - Division
P - Previous games history
Q - Quit the game");


    //User input for options and logic
    option = Console.ReadLine().ToLower().Trim();

    switch (option)
    {
        case "a":
            game.AdditionGame();
            break;
        case "s":
            game.SubtractionGame();
            break;
        case "m":
            game.MultiplicationGame();
            break;
        case "d":
            game.DivisionGame();
            break;
        case "p":
            if (game.previousGames.Count() == 0)
            {
                Console.WriteLine("There has not been any game played at this time");
            }
            else
            {
                foreach (var score in game.previousGames)
                {
                    Console.WriteLine(score);
                }
            }

            break;
        case "q":
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }


    //Methods

} while (true);