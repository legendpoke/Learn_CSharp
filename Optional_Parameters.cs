using System;
using System.Collections.Generic;
using System.Text;

class Players {
    public static void PlayerInfo(
        string name = "Unknow",
        int hp = 100,
        int level = 1
        ) {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Level :" + level);
        Console.WriteLine("Hp :" + hp);
    }
}


namespace C__Course
{
    class Optional_Parameters
    {
        static void optional_parameters(string[] args) {
            Players.PlayerInfo();
            Players.PlayerInfo("Dhruv");
            Players.PlayerInfo("Ayan",200,2);
            Players.PlayerInfo("",400,4);
            Players.PlayerInfo(name : "RayMond Luis",level : 200,hp : 20000 );

        }
    }
}
