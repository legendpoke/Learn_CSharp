using System;
using System.Collections.Generic;
using System.Text;

delegate void Calc();

class Calculator {
    public void add() {
        int x = 40;
        int y = 10;
        Console.WriteLine("x+ y:" + (x+ y));
    }

    public void sub()
    {
        int x = 10;
        int y = 20;
        int result = x - y;
        Console.WriteLine(" x - y:" + result);
    }
}

namespace C__Course
{
    class Delegate
    {
        static void Delegates(string[] args)
        {
            Calculator c = new Calculator();

            Calc addition = c.add;
            addition();


            Calc subtraction = c.sub;
            subtraction();
        }
    }
}
