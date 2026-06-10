using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Input_user {
        static void input(string[] args) {
            //input in string 
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            // imput in integer 
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number is: " + num);

            // by using paras
            Console.Write("Enter a number: ");
            int num_one;

            if (int.TryParse(Console.ReadLine(), out num_one))
            {
                Console.WriteLine("Valid number: " + num_one);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
