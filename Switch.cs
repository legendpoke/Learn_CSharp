using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Switch {
        static void Switch_statements(string[] args) {
            int playerState = 6;
            switch (playerState) {
                case 0:
                    Console.WriteLine("idel");
                    break;
                case 1:
                    Console.WriteLine("Running");
                    break;
                case 2:
                    Console.WriteLine("Jumping");
                    break;
                default:
                    Console.WriteLine("unknown state");
                    break;
            }
        }
    }
}
