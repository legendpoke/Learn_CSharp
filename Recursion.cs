using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Recursion
    {
        static void recursion(string[] args) {
            int Factorial(int n)
            {
                if (n == 1)
                    return 1;

                return n * Factorial(n - 1);
            }

            int result = Factorial(5);
            Console.WriteLine(result);
        }
    }
}
