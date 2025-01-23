using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftProblems
{
    public class PractiseProblems
    {
        public static void Main(string[] args)
        {
            // print prime numbers upto n

            for (int i = 2; i <= 50; i++)
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
                    Console.Write(i + " ");
                }
            }

            //print even numbers upto n

            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }

            //print Fibnocci series
            int first = 0, second = 1;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write(first + " ");
                int next = first + second;
                first = second;
                second = next;
            }
        }
    }
}
