using System;
using System.Collections.Generic;
using System.Text;

class Cars {
    public string brand;
    public int speed;
    public Cars(string b, int s) {
        brand = b;
        speed = s;
    }
    public void Display() {
        Console.WriteLine("car Brand:" + brand + " " + "Speed:" + speed );
    }
}

namespace C__Course
{
    class Program_one {
        static void Cunstructors(string[] args) {
            Cars c1 = new Cars("Lamborgini", 300);
            c1.brand = "BMW";//get higher priority to this 
            c1.Display();
            Cars c2 = new Cars("",0);
            c2.brand = "Lamborgini";
            c2.speed = 500;
            c2.Display();
        }
    }
}
