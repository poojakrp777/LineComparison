using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to line comparison");
            Console.WriteLine("\t\tEnter values for Line No 1: ");

            Console.WriteLine("Enter Value of : X1");
            //string value converted to integer
            int X1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : X2");
            int X2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y1");
            int Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y2");
            int Y2 = Convert.ToInt32(Console.ReadLine());

            //2st part line no 2 : L2

            Console.WriteLine("\t\tEnter values for Line No 2: ");


            Console.WriteLine("Enter Value of : X3");
            int X3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : X4");
            int X4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y3");
            int Y3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Value of : Y4");
            int Y4 = Convert.ToInt32(Console.ReadLine());

            //using double to get square root value in double decimal points

            //to compare two lines we need 2 lengths as L1 and L2
            double Length1 = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            Console.WriteLine("Length of the line is :" + Length1);

            double Length2 = Math.Sqrt((Math.Pow((X4 - X3), 2) + Math.Pow((Y4 - Y3), 2)));
            Console.WriteLine("Length of the line is :" + Length2);
            Console.ReadLine();

            //using sequence selection to check lines are equal or not 
            if (Length1 == Length2)
            {
                Console.WriteLine("BOTH LINES ARE EQUAL");
            }

            else if (Length1 > Length2)
            {
                Console.WriteLine("Length1 IS GREATER THAN Length2");
            }
            else
            {
                Console.WriteLine("Length1 IS LESS THAN Length2");
            }
        }
    }
}
