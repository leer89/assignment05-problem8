using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment05_problem8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 8. Prompt the user for the length of three line segments as integers.If the three lines
            could form a triangle, print the integers and a message indicating they form a
            triangle. Use a state - controlled loop to allow users to enter as many different
            combinations as they want. */

            int side1, side2, side3;
            string s1, s2, s3;
            bool keepGoing = true;
            string decision;

            while (keepGoing)
            {
                Console.WriteLine("Give 3 sides and I will tell you if a triangle can be formed: ");
                s1 = Console.ReadLine();
                s2 = Console.ReadLine();
                s3 = Console.ReadLine();

                side1 = int.Parse(s1);
                side2 = int.Parse(s2);
                side3 = int.Parse(s3);

                if ((side1 + side2) > side3)
                {
                    Console.WriteLine("Triangle is possible. Side1 + Side2 is larger than Side3.");
                    Console.WriteLine("Try again? (n to exit): ");
                    decision = Console.ReadLine();
                    if (decision == "n")
                        keepGoing = false;
                }
                else
                    Console.WriteLine("Triangle not possible. Try again.");
            }
        }
    }
}
