using System;
using System.Linq;

namespace OnlineExercises2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
//            9.Write a C# Sharp program that takes four numbers as input to calculate and print the average.
//            Test Data:
//            Enter the First number: 10
//            Enter the Second number: 15
//            Enter the third number: 20
//            Enter the four number: 30
//
//            Expected Output:
//            The average of 10 , 15 , 20 , 30 is: 18

            var order = new string[4] {"first", "second", "third", "fourth"};
            var numbers = new int[4];
            //var input = Console.ReadLine();
            var result = 0;
            for (var i = 0; i <= 3; i++)
            {
                Console.WriteLine("please enter the " + order[i] + " number: ");
                var input = Console.ReadLine();

                if (!int.TryParse(input, out numbers[i]))
                {
                    i = i - 1;
                    Console.WriteLine("Unable to convert your entry into a valid number, please try again");
                }
            }

            Console.WriteLine("The average of number " + numbers[0] + " number " + numbers[1] + " number " +
                              numbers[2] + " and number " + numbers[3] + " = " + numbers.Average());
        }
    }
}