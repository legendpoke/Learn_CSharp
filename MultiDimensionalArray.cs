using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class MultiDimensionalArray {
        static void three_d(string[] args) {
            Random random = new Random();
            int array = random.Next(0, 28);
            int[,,] result = new int[3,3,3];
            for (int i = 0; i< result.GetLength(0);i++) {
                Console.Write(i + "[i]");
                for (int j = 0; j < result.GetLength(1); j++) {
                    Console.Write(j + "[j]");
                    for (int k = 0; k < result.GetLength(2); k++) {
                        result[i, j, k] = array;
                        //array = result[i, j, k];
                        Console.Write(array + "[k]");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            Console.WriteLine(result[0,0,2]);
        }
    }
}
