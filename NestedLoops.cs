using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class NestedLoops
    {
        static void Nested_Loops(string[] args) {
            for (int i = 0; i < 3;i++) {
                //Console.Write(i + " ");
                for (int j = 0;j < 3;j++) {
                    Console.Write(i + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
