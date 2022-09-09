using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the action to be Performed");
            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Subtraction");
            Console.WriteLine("Press 3 for Multiplication");
            Console.WriteLine("Press 4 for Division \n");

            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Input");
            int inp_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Input");
            int inp_2 = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Addition(inp_1, inp_2);
                        break;
                    }
                case 2:
                    {
                        result = Subtraction(inp_1, inp_2);
                        break;
                    }
                case 3:
                    {
                        result = Multiplication(inp_1, inp_2);
                        break;
                    }
                case 4:
                    {
                        result = Division(inp_1, inp_2);
                        break;
                    }
                default:
                    Console.WriteLine("Wrong Action!! Try Again.");
                    break;
            }
            Console.WriteLine("The Result is {0}", result);
            Console.ReadKey();
        }

        // Addition
        public static int Addition(int inp_1, int inp_2)
        {
            int result = inp_1 + inp_2;
            return result;
        }

        // Subtraction
        public static int Subtraction(int inp_1, int inp_2)
        {
            int result = inp_1 - inp_2;
            return result;
        }

        // Multiplication
        public static int Multiplication(int inp_1, int inp_2)
        {
            int result = inp_1 * inp_2;
            return result;
        }

        // Division
        public static int Division(int inp_1, int inp_2)
        {
            int result = inp_1 / inp_2;
            return result;
        }
    }
}
