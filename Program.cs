using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        public class Pair
        {
            public int first, second;

            public Pair(int first, int second)
            {
                this.first = first;
                this.second = second;
            }
        }

        // Function to find the line given two points
        static void lineFromPoints(Pair P, Pair Q)
        {
            int a = Q.second - P.second;
            int b = P.first - Q.first;
            int c = a * (P.first) + b * (P.second);

            if (b < 0)
            {
                Console.WriteLine("The line passing through points P and Q is: "+ a + "x - " + b + "y = " + c);
            }
            else
            {
                Console.WriteLine("The line passing through points P and Q is: "+ a + "x + " + b + "y = " + c);
            }
        }

        // Driver code
        public static void Main(String[] args)
        {
            Pair P = new Pair(3, 2);
            Pair Q = new Pair(2, 6);
            lineFromPoints(P, Q);
        }
    }
}
