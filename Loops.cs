using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Loops {
        static void Loops_statments(string[] args) {
            //for loop
            Console.WriteLine("for loop");
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("i" + i);
            }
            //while loop
            Console.WriteLine("while loop");
            int a = 10;
            while (a <1000) {
                a = a + 50;
                Console.WriteLine("a"+a);
            }
            //do-while
            Console.WriteLine("do-while loop");
            int b = 10;
            do
            {
                b = b - 1;
                Console.WriteLine("b" + b);
            } while (b > 1);
            //for each
            Console.WriteLine("foreach loop");
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            foreach (int num in nums) {
                if (num % 2 == 0) {
                    Console.WriteLine("num" + num);
                }
            }
            //break 
            Console.WriteLine("break loop");
            for (int c = 1; c <= 5; c++) {
                if (c == 3) {
                    break;
                }
                Console.WriteLine("c" + c);
            }
            //continue
            Console.WriteLine("continue loop");
            for (int d = 1; d <= 5; d++)
            {
                if (d == 3)
                {
                    continue;
                }
                Console.WriteLine("d" + d);
            }
        }
    }
}
