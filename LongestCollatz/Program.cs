using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace LongestCollatz
{
    public class Program
    {
        static void Main(string[] args)
        {
            //The following iterative sequence is defined for the set of positive integers:

            //n → n / 2(n is even)
            //n → 3n + 1(n is odd)

            //Using the rule above and starting with 13, we generate the following sequence:
            //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1

            //It can be seen that this sequence(starting at 13 and finishing at 1) contains 10 terms.Although it
            //has not been proven yet(Collatz Problem), it is thought that all starting numbers finish at 1.

            //Which starting number, under one thousand, produces the longest chain ?

            int x = 999;
            int count = 1;
            int largest = 0;
            string chain = "";
            int printStartingNumber = x;
            int printCount = count;
            int printLargest = 0;
            int printSmallest = x;
            string printChain = "";

            for (int i = 1; i < 999; i++)
            {
                x = i;
                count = 1;
                largest = 0;
                chain = "";
                
                while (x > 1)
                {
                    if (x % 2 == 0)
                    {
                        x = x / 2;
                    }
                    else
                    {
                        x = 3 * x + 1;
                    }
                    
                    if (x > largest)
                    {
                        largest = x;
                    }

                    if (count == 1)
                    {
                        chain = i.ToString() + "->";
                    }

                    chain += x.ToString() + "->";
                    count++;

                    Console.WriteLine("**** Working On It ****");
                }

                if (count > printCount)
                {
                    printStartingNumber = i;
                    printCount = count;
                    printSmallest = x;
                    printChain = chain;
                    printLargest = largest;
                }
            }

            Console.Clear();
            Console.WriteLine($"{printChain}");
            Console.WriteLine($"\n\n{printStartingNumber} Is the starting number.");
            Console.WriteLine($"There are {printCount} terms.");
            Console.WriteLine($"The largest number is {printLargest}");
            Console.WriteLine($"The smallest number is {printSmallest}");
        }
    }
}