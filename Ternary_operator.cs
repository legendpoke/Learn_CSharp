using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Ternary_operator {
        static void Ternary(string[] args) {
            int num = 11;
            string result = (num % 2 == 0) ? "Even" : "odd";
            Console.WriteLine(result);
        }
    }
}
