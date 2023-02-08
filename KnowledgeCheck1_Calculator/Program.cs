using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            string[] GetTwoInts()
            {
                string[] UserInput = new string[2];
                UserInput[0] = Console.ReadLine();
                UserInput[1] = Console.ReadLine();


                return UserInput;
            }
            //This didn't really simplify the code or make it less redundant, but I tried. ugh.

            void InvalidInput()
            {
                Console.WriteLine("One or more of these numbers is not an integer");
            }

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Enter 2 integers to add");
                    var addNumbers = GetTwoInts();

                    if (int.TryParse(addNumbers[0], out int addNumOne) &&
                        int.TryParse(addNumbers[1], out int addNumTwo))
                    {
                        Console.Write($"{addNumbers[0]} + {addNumbers[1]} = ");
                        Console.Write(calculator.Add(addNumOne, addNumTwo));
                    }
                    else
                    {
                        InvalidInput();
                    }
                    break;

                case "2":
                    Console.WriteLine("Enter 2 integers to subtract");
                    var subNumbers = GetTwoInts();

                    if (int.TryParse(subNumbers[0], out int subNumOne) &&
                        int.TryParse(subNumbers[1], out int subNumTwo))
                    {
                        Console.Write($"{subNumbers[0]} - {subNumbers[1]} = ");
                        Console.Write(calculator.Subtract(subNumOne, subNumTwo));
                    }
                    else
                    {
                        InvalidInput();
                    }
                    break;

                case "3":
                    Console.WriteLine("Enter 2 integers to multiply");
                    var multNumbers = GetTwoInts();

                    if (int.TryParse(multNumbers[0], out int multNumOne) &&
                        int.TryParse(multNumbers[1], out int multNumTwo))
                    {
                        Console.Write($"{multNumbers[0]} * {multNumbers[1]} = ");
                        Console.Write(calculator.Multiply(multNumOne, multNumTwo));
                    }
                    else
                    {
                        InvalidInput();
                    }
                    break;

                case "4":
                    Console.WriteLine("Enter 2 integers to divide");
                    var divideNumber1 = Console.ReadLine();
                    var divideNumber2 = Console.ReadLine();

                    if (double.TryParse(divideNumber1, out double divNumOne) && double.TryParse(divideNumber2, out double divNumTwo))
                    {
                        Console.Write($"{divideNumber1} / {divideNumber2} = ");
                        Console.Write(calculator.Divide(divNumOne, divNumTwo));
                    }
                    else
                    {
                        InvalidInput();
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }
    }
}