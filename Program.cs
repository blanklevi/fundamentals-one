using System;

namespace FundamentalsOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 256)
            {
                Console.WriteLine(num);
                num++;
            }
            int num1 = 1;
            for (int i = num1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
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
            }
        }
    }
}
