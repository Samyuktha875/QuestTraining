using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            
                Console.WriteLine("Enter the first number:");
                int number1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the operator (+, -, *, /):");
                char op = Console.ReadLine()[0];

                Console.WriteLine("Enter the second number:");
                int number2 = int.Parse(Console.ReadLine());

                int result = 0;

                if (op == '+')
                {
                    result = number1 + number2;
                }
                else if (op == '-')
                {
                    result = number1 - number2;
                }
                else if (op == '*')
                {
                    result = number1 * number2;
                }
                else if (op == '/')
                {
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid operator");
                    return;
                }

                Console.WriteLine("The result is: " + result);
            }
        }

    }


