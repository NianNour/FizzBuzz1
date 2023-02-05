using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            int number;
                Console.WriteLine("Please enter the number.");
                n = Console.ReadLine();
                number = Convert.ToInt32(n);
                for (int i = 1; i <= number; i++)
                {
                    if (i % 15 == 0)
                    {
                        Console.WriteLine("FizzBuzz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.WriteLine("Fizz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            
        }
    }
}
