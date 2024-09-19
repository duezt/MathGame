using MathGame;
using System.Numerics;


//Variables


string name = "";
DateTime date = DateTime.Now;
string option = "";

//List

var previousGames = new List<string>();




//Display menu and user name's input
Console.WriteLine("What is your name?");
name = Console.ReadLine();

while (true)
{


Console.WriteLine($@"Welcome to the math game {name}, today is {date.DayOfWeek}
Please select one of the following games option:
A - Addition 
S - Substraction 
M - Multiplication
D - Division");


//User input for options and logic

option = Console.ReadLine().ToLower().Trim();

switch (option)
{
    case "a":
        AdditionGame();
        break;
    case "s":
        SubtractionGame();
        break;
    case "m":
        MultiplicationGame();
        break;
    case "d":
        DivisionGame();
        break;
        case "e":
        foreach (var score in previousGames)
        {
            Console.WriteLine(score);
        }
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}


//Methods

void AdditionGame()
{


    var dateStarted = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
    var rand = new Random();

    int correctAnwsercounter = 0;
    int IncorrectAwnserCounter = 0;

    for (int i = 0; i < 5; i++)
    {
        bool isNumber = false;

        int firstNumber = rand.Next(1, 100);
        int secondNumber = rand.Next(1, 100);
        int operationResults = firstNumber + secondNumber;
        Console.WriteLine($"{firstNumber} + {secondNumber} = ?");


        while (isNumber == false)
        {
            string userInput = Console.ReadLine().Trim();
            int userAnwser;

            if (int.TryParse(userInput, out userAnwser))
            {



                if (userAnwser == operationResults)
                {
                    Console.WriteLine($"You're anwser is correct! {firstNumber} + {secondNumber} = {operationResults}");
                    correctAnwsercounter++;
                }
                else
                {
                    Console.WriteLine($"You're anwser is incorrect! the correct anwser is {operationResults} and you're answer was {userAnwser}");
                    IncorrectAwnserCounter++;
                }

                isNumber = true;

            }
            else
            {
                Console.WriteLine("Please, type in a number not letters");


            }
        }


    }
    var scoreResult = correctAnwsercounter < IncorrectAwnserCounter ? $"you have lost this addition game with {IncorrectAwnserCounter} of 5 questions" : $"you have Won this addition game with {correctAnwsercounter} of 5 questions";
    previousGames.Add($"You played this game at {dateStarted} and {scoreResult.ToUpper()}");
}



void SubtractionGame()
{

    var rand = new Random();

    int correctAnwsercounter = 0;
    int IncorrectAwnserCounter = 0;

    for (int i = 0; i < 5; i++)
    {
        bool isNumber = false;

        int firstNumber = rand.Next(1, 100);
        int secondNumber = rand.Next(1, 100);
        int operationResults = firstNumber - secondNumber;
        Console.WriteLine($"{firstNumber} - {secondNumber} = ?");


        while (isNumber == false)
        {
            string userInput = Console.ReadLine().Trim();
            int userAnwser;

            if (int.TryParse(userInput, out userAnwser))
            {



                if (userAnwser == operationResults)
                {
                    Console.WriteLine($"You're anwser is correct! {firstNumber} - {secondNumber} = {operationResults}");
                    correctAnwsercounter++;
                }
                else
                {
                    Console.WriteLine($"You're anwser is incorrect! the correct anwser is {operationResults} and you're answer was {userAnwser}");
                    IncorrectAwnserCounter++;
                }

                isNumber = true;

            }
            else
            {
                Console.WriteLine("Please, type a number not letters");


            }
        }
    }
}


void MultiplicationGame()
{

    var rand = new Random();

    int correctAnwsercounter = 0;
    int IncorrectAwnserCounter = 0;

    for (int i = 0; i < 5; i++)
    {
        bool isNumber = false;

        int firstNumber = rand.Next(1, 100);
        int secondNumber = rand.Next(1, 100);
        int operationResults = firstNumber * secondNumber;
        Console.WriteLine($"{firstNumber} x {secondNumber} = ?");


        while (isNumber == false)
        {
            string userInput = Console.ReadLine().Trim();
            int userAnwser;

            if (int.TryParse(userInput, out userAnwser))
            {



                if (userAnwser == operationResults)
                {
                    Console.WriteLine($"You're anwser is correct! {firstNumber} x {secondNumber} = {operationResults}");
                    correctAnwsercounter++;
                }
                else
                {
                    Console.WriteLine($"You're anwser is incorrect! the correct anwser is {operationResults} and you're answer was {userAnwser}");
                    IncorrectAwnserCounter++;
                }

                isNumber = true;

            }
            else
            {
                Console.WriteLine("Please, type a number not letters");


            }
        }
    }
}


void DivisionGame()
{



    var rand = new Random();

    int correctAnwsercounter = 0;
    int IncorrectAwnserCounter = 0;

    for (int i = 0; i < 5; i++)
    {
        bool isNumber = false;
        int firstNumber = rand.Next(1, 25);
        int secondNumber = rand.Next(1, 100);

        //This variable would give always a divend that will give a intenger result.
        int dividend = firstNumber * secondNumber;
        int operationResults = dividend / firstNumber;
        Console.WriteLine($"{dividend} / {firstNumber} = ?");


        while (isNumber == false)
        {
            string userInput = Console.ReadLine().Trim();
            int userAnwser;

            if (int.TryParse(userInput, out userAnwser))
            {



                if (userAnwser == operationResults)
                {
                    Console.WriteLine($"You're anwser is correct! {firstNumber} / {secondNumber} = {operationResults}");
                    correctAnwsercounter++;
                }
                else
                {
                    Console.WriteLine($"You're anwser is incorrect! the correct anwser is {operationResults} and you're answer was {userAnwser}");
                    IncorrectAwnserCounter++;
                }

                isNumber = true;

            }
            else
            {
                Console.WriteLine("Please, type in a number not letters");


            }
        }
    }
}
}

