using System;
using System.Collections.Generic;
using System.Text;

class Students {
    public string? name;
    public int age;
    public void ShowDetails() {
        Console.WriteLine("name:" + name + " " + "age:" + age);
    }
}

namespace C__Course
{
    class Program {
        static void Class_Objects(string[] args) {
            Students s1 = new Students();
            s1.name = "Dhruv";
            s1.age = 19;
            s1.ShowDetails();
        }
    }
    
}
