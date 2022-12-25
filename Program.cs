using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter  the lower bound:");
            int n1 = int .Parse(Console.ReadLine());
            Console.WriteLine("Enter  the upper bound:");
            int n2 = int.Parse(Console.ReadLine());
            
            
            for (int i =n1; i <= n2; i++)
            {
                int sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i%j==0)
                    {
                        sum+=j; 
                    }
                }

                if (sum == i)
                {
                    Console.WriteLine(i+"is a perfect number");
                }

                    
                
            }
           

            
        }
    }
}
