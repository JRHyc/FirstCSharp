using System;

namespace FirstCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // loop from 1 to 5 including 5
                // for (int i = 1; i <= 255; i++)
                // {
                //     Console.WriteLine(i);
                // }
                for (int j = 1; j <=100; j++)
                {
                    if (j % 3 == 0 && j % 5 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    
                    else if (j % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                        
                    }
                    else if (j % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }

                }
            string place = "Coding Dojo";
            Console.WriteLine($"Hello {place}");
        }
    }
}
