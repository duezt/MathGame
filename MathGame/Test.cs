using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    public class Test
    {
        
        public void Method()
        {
            for (int i = 1; i > 100; i++)
            {

                for (int j = 1; j > 100; j++)
                {

                    if (i % j == 0)
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine(j);
                    }
                }
            }
        }
    } 
        
      
 }

