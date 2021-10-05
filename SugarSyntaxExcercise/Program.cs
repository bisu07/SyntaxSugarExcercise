using System;
using System.Transactions;

namespace SugarSyntaxExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the answer :");
            var answer = Convert.ToInt32(Console.ReadLine());


            var response  = (answer < 9)?$"{answer} is less than nine":
             $"{answer} is greater than or equal to  9";
            Console.WriteLine(response);

        }
    }
}
