using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class GameEngine
    {


        public List<string> previousGames { get; private set; }

        public GameEngine() 
        {
            previousGames = new List<string>();
            
        }
      

       int timesPlayed = 0;

        internal void AdditionGame()
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
            var scoreResult = correctAnwsercounter < IncorrectAwnserCounter ? $"you lost with {IncorrectAwnserCounter} incorrect anwsers of 5 questions" : $"you have Won this addition game with {correctAnwsercounter} of 5 questions";
            previousGames.Add($"{++timesPlayed}- You played Addition game at {dateStarted} and {scoreResult.ToUpper()}");
        }



        internal void SubtractionGame()
        {

            var rand = new Random();
            var dateStarted = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

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

            var scoreResult = correctAnwsercounter < IncorrectAwnserCounter ? $"you lost with {IncorrectAwnserCounter} incorrect anwsers of 5 questions" : $"you Won with {correctAnwsercounter} correct anwsers of 5 questions";
            previousGames.Add($"{++timesPlayed} -You played the substraction game at {dateStarted} and {scoreResult.ToUpper()} ");
        }


        internal void MultiplicationGame()
        {

            var rand = new Random();
            var dateStarted = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
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

            var scoreResult = correctAnwsercounter < IncorrectAwnserCounter ? $"you lost with {IncorrectAwnserCounter} incorrect anwsers of 5 questions" : $"you Won with {correctAnwsercounter} correct anwsers of 5 questions";
            previousGames.Add($"{++timesPlayed} -You played the multiplicacion game at {dateStarted} and {scoreResult.ToUpper()} ");
        }


        internal void DivisionGame()
        {



            var rand = new Random();
            var dateStarted = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");
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
            var scoreResult = correctAnwsercounter < IncorrectAwnserCounter ? $"you lost with {IncorrectAwnserCounter} incorrect anwsers of 5 questions" : $"you Won with {correctAnwsercounter} correct anwsers of 5 questions";
            previousGames.Add($"{++timesPlayed} -You played the division game at {dateStarted} and {scoreResult.ToUpper()}");
        }
    }


}

