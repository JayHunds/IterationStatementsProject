using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            

            int num = 0;

            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);

            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            Console.WriteLine("Increase:");

            foreach (int number in numbers)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

            
        }
    }
}
