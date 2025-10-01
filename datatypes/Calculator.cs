using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DOTNETPRACTICE.datatypes
{
    public class Calculator
    {

        int a;
        int b;
        char options;
        public void Cal()
        {

            while (true) 
            {
                Console.WriteLine("Choose Optione to performe else enter = to exit");
                options = Convert.ToChar(Console.ReadLine());
                if (options != '=')
                    calculator(options);
                else
                    break;
            } 
        }
        public void calculator(char option)
        {
            Console.WriteLine("Enter A value");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value");
            b = Int32.Parse(Console.ReadLine());
            if (option == '+')
                Console.WriteLine("Sum of {0},{1} is{2}", a, b, a + b);
            else if (option == '-')
                Console.WriteLine("Sub of {0},{1} is {2}", a, b, a - b);
            else if (option == '*')
                Console.WriteLine("mul of {0},{1} {2}", a, b, a * b);
            else if (option == '/')
            {
                if (b > 0)
                    Console.WriteLine("Div of {0},{1} {2}", a, b, a / b);
                else
                    Console.WriteLine("0 Can't devide");
            }

            else if (option == '%')
                Console.WriteLine("Sum of {0},{1} {2}", a, b, a + b);
            else
                Console.WriteLine("Choose correct Option:");
        }

    }
}
