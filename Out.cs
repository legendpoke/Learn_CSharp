using System;
using System.Collections.Generic;
using System.Text;


class Out {
    public static void GetValues(out int sum, out int product)
    {
        sum = 10 + 5;
        product = 10 * 9;
    }
}


namespace C__Course
{
    class Program_six {
        static void Out_method()
        {
            int s, p;
            Out.GetValues(out s, out p);

            Console.WriteLine(s); // 15
            Console.WriteLine(p); // 90
        }
    }
}
