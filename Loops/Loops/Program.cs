using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            double answer;
            double total=0;

            for (int i = 0; i <3; i++)
            {
                Console.WriteLine("What did you get on your test?");
                answer = Convert.ToDouble(Console.ReadLine());
                total = total + answer;
            }
            var average = (total / 3)/100;


            Console.WriteLine($"Your test average is {average.ToString("P2")}");
            Console.ReadKey();
        }
    }
}
