using System;
using System.Text;

namespace PracticePrograms
{

    /* Factors are the numbers you multiply to get another number
     * Factors of 6
     * 1*6, 2*3, 3*2,6*1
     * factors of 6 are 1,2,3,6
     * Sum of factors=12
     */
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please provide input numbers");
            int input = Int32.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= input; i++)
            {
                
                   
                if(input%i is 0)
                {
                    Console.WriteLine($"{i} is factors of {input}");
                    sum = sum + i;
                }
                
            }

            Console.WriteLine($"Sum of factors of {input} no. {sum}");
        }
    }
}
