using MathGame;
using System.Numerics;


//Variables


string name = "";
DateTime date = DateTime.Now;
string option = "";


//Display menu and user name's input
Console.WriteLine("What is your name?");
name = Console.ReadLine();
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
    default:
        Console.WriteLine("Invalid input");
        break;
}


void AdditionGame()
{



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
        int operationResults =  dividend / firstNumber;
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