using System;
using System.Collections.Generic;
using System.Text;


class Demo
{
    public static void Show()
    {
        Console.WriteLine("Hello");
    }
}

class Counter
{
    public static int count = 0;
}


namespace C__Course
{
    class Program_four
    {
        static void Static()
        {
            Demo.Show();// no object needed
            Counter.count++;
            Counter.count++;
            Counter.count++;
            Counter.count++;
            Console.WriteLine(Counter.count);
            
        }
    }
}
