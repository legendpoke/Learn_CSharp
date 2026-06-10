using System;
using System.Collections.Generic;
using System.Text;

interface IFly {
    void fly() {
        Console.WriteLine("Default");
    }
}

interface ISwim {
    void swim();
}

class Duck : IFly, ISwim {
    public void fly() { 
        Console.WriteLine("Duck Fly"); 
    }
    public void swim() { 
        Console.WriteLine("Duck Swim"); 
    }
}

interface ITest {
    void show() {
        Console.WriteLine("Testing explicit");
    }
}

class D_emo : ITest {
    void ITest.show()
    {
        Console.WriteLine("Explicit working");
    }
}

namespace C__Course
{
    class Interfaces
    {
        static void Inter_Faces(string [] args) {
            Duck duck = new Duck();
            duck.fly();
            duck.swim();

            IFly du_ck = new Duck();
            du_ck.fly();

            // EXPLICIT INTERFACE IMPLEMENTATION
            ITest test = new D_emo();
            test.show();
        }
    }
}
