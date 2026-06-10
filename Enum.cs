using System;
using System.Collections.Generic;
using System.Text;

enum Levels {
    Easy,
    Medium,
    Hard
}


namespace C__Course
{
    class Enum
    {
        static void Enums(string[] args) {
            Levels one = Levels.Hard;
            Console.WriteLine(one);//hard
            Console.WriteLine((int)one);
        }
    }
}
