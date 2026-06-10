using System;
using System.Collections.Generic;
using System.Text;

struct B { 
    public int x; 
}

namespace C__Course
{
    class Struct
    {
        static void Structs(string[] args) {
            B b1;
            b1.x = 10;

            B b2 = b1;
            b2.x = 20;

            Console.WriteLine(b1.x);//10
            Console.WriteLine(b2.x);//20

        }
    }
}
