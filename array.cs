using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Arrays {
        static void arrays(string[] args) {
            //elements access
            int[] nums = { 10,4,5,3,90,23,56 };
            for (int i = 0; i < nums.Length; i++) {
                Console.WriteLine(nums[i]);
            }
            //rank of a array
            Console.WriteLine("Rank" + nums.Rank);
            //revserse array print
            Array.Reverse(nums);
            Console.WriteLine("Reversed Array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            //sorted array print
            Array.Sort(nums);
            Console.WriteLine("Sorted Array:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            //length of an array
            Console.WriteLine("Lenght of the array " + nums.Length);
        }
    }
}
