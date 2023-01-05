using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Utils
{
    internal class Test
    {
        static void Main()
        {
            string message, str1;

            // Get an input string
            Console.WriteLine("Enter string to reverse:");
            message = Console.ReadLine();

            // Reverse the string
            Utils.Reverse(message, out str1);

            // Display the result
            Console.WriteLine(str1);

            Console.Read();

        }

    }

}


