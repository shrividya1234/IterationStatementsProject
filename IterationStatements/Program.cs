using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            
           var num = 0;
            List<int> numbers = new List<int>(); 
            Console.WriteLine("****DO WHILE****");
          do
          {
              num++;
              numbers.Add(num);
              Console.Write(num);
          } while (num<100); 
          Console.WriteLine(); 
          
         Console.WriteLine("***WHILE LOOP***");
          num = 0;
         while (num <= 50)
           {
             num++;
             numbers.Add(num);
             Console.Write(num+ "");
         }
         
         Console.WriteLine(); 
         Console.Write("****FOR LOOP**** Listing all the numbers on the list: " );
         Console.WriteLine(); 
             for (int i = 0; i < numbers.Count ; i++)
             {
                 Console.Write(numbers[i] +" ");
             }
             Console.WriteLine(); 
             Console.Write("End of the Loop");
         
       
            Console.WriteLine("");
            Console.WriteLine("**DECREMENT FOR LOOP***:");
             
            for (int i = 99; i >= 0; i--)
            {
                // Check if the index is within the bounds of the numbers list
                if (i < numbers.Count)
                {
                    Console.WriteLine(numbers[i]);
                }

            }

        }
    }
}
