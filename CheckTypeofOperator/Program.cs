using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckTypeofOperator
{
    class Program
    {
        static void Main(string[] args)
        {

            string i;
            Console.WriteLine("enter the charecter:");
            i = Console.ReadLine();
            if (i == "+" || i == "-" || i == "*" || i == "/" || i == "%" || i == "++" || i == "--")
            {
                Console.WriteLine("{0} is an arithmetic operator.", i);
            }
            else
            {
                if (i == "==" || i == "!=" || i == ">" || i == "<" || i == ">=" || i == "<=" || i == "&&" || i == "||" || i == "!")
                {
                    Console.WriteLine("{0} is a logial operator.", i);
                }
                else
                {
                    if (i == "&" || i == "|" || i == "^" || i == "~" || i == "<<" || i == ">>")
                    {
                        Console.WriteLine("{0} is an bitwise operator.", i);
                    }
                    else
                    {
                        if (i == "=" || i == "+=" || i == "-=" || i == "=+" || i == "=-" || i == "=*")
                        {
                            Console.WriteLine("{0} is an assignment operator.");
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
