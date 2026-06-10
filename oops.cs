using System;
using System.Collections.Generic;
using System.Text;

class Animal {
    public void eat() {
        Console.WriteLine("Animal Eating");
    }
    public virtual void sound() {
        Console.WriteLine("Animal makes Sound");
    }
}

class Dog : Animal {
    public override void sound() {
        Console.WriteLine("Barks");
    }
}

namespace C__Course
{
    class Oops {
        static void oops(string[] args) {
            //Dog d = new Dog();// ye bhee same answer dega
            Animal d = new Dog();
            d.sound();//polymorphism and methods overide
            d.eat();//inheritence
        }
    }
}
