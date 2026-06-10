using System;
using System.Collections.Generic;
using System.Text;

public class Marks {
    private int _marks;
    private string? name;
    public int Mmarks {
        get { return _marks; }
        set {
            _marks = 200;
        }
    }
    public string Name {
        get { return name; }
        set {
            name = "Ayan";
        }
    }
}

namespace C__Course
{
    class Properties {
        static void properties(string[] args) {
            Marks m = new Marks();
            m.Mmarks = 0;// they do not affect the get and set methodhs
            Console.WriteLine(m.Mmarks);
            m.Name = "Dhruv";// they do not affect the get and set methodhs
            Console.WriteLine(m.Name);

        }
    }
}
