using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {

        public int CheckUserInput()
        {
            bool isNumber = false;
            int userNumber = 0;
            while (isNumber == false)
            {
                string userInput = Console.ReadLine().Trim();
                

                if (int.TryParse(userInput, out userNumber))
                {


                    isNumber = true;

                }
                else
                {
                    Console.WriteLine("Please, type in a number not letters");


                }

            }

            return userNumber;
        }
    }
}
