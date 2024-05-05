using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace simpleArithmeticCalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float number1, number2;
            char operators;

            Console.Write("Enter first number: ");
            number1 = Single.Parse(Console.ReadLine());
            Console.Write("Enter first number: ");
            number2 = Single.Parse(Console.ReadLine());
            Console.Write("Enter operator: ");
            operators = Console.ReadKey().KeyChar;



            switch(operators)
            {
                case '+':
                    {
                        float sum = number1 + number2;
                        Console.WriteLine("\nThe Sum: " + sum);
                    }
                    break;
                case '-':
                    {
                        float difference = number1 - number2;
                        Console.WriteLine("\nThe Difference: " + difference);
                    }
                    break;
                case '*':
                    {
                        float product = number1 * number2;
                        Console.WriteLine("\nThe Product: " + product);
                    }
                    break;
                case '/':
                    {
                        float quotient = number1 / number2;
                        Console.WriteLine("\nThe Quotient: " + quotient);
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break ;
            }

            Console.ReadKey();
        }
    }
}
