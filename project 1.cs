using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, Enter n1");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, Enter n2");
            int n2 = int.Parse(Console.ReadLine());
            for (int i = n1; i < n2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }



        }
    }
}
