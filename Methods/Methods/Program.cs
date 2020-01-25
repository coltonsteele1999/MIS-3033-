using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static double LineValueForY()
        {
            Console.WriteLine("What is the slope of your function?");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your x value?");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your y-intercept?");
            double b = Convert.ToDouble(Console.ReadLine());

            double y = m * x + b;
            Console.WriteLine($"The y value of your function is {y}");
            return y;
        }
        static int Factorial()
        {
            Console.WriteLine("What integer would you like to know the factorial of?");
            int answer = Convert.ToInt32(Console.ReadLine());

            int number=1;
            for (int i = 1; i <= answer; i++)
            {
                number = number * i;
            }
            Console.WriteLine($"The factorial of your number is {number}");
            return number;
            
        }

        static void Main(string[] args)
        {
            LineValueForY();

            Console.WriteLine("---------------------");
            Factorial();
            Console.ReadKey();
        }
    }
}
