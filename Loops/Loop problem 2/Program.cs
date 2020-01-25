using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            string answer2;
            double answer;
            double total=0;
            string loweranswer2;
            do
            {
                Console.WriteLine("What did you get on your exam?");
                answer = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Would you like to enter another score?");
                answer2= Convert.ToString(Console.ReadLine());
                loweranswer2 = answer2.ToLower();
                total = answer + total;
                i++;

            } while (loweranswer2 == "yes") ;

            var average = (total / i) / 100;

            Console.WriteLine($"Your test average is {average.ToString("P2")}");

            Console.ReadKey();
        }
    }
}
