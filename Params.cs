using System;
using System.Collections.Generic;
using System.Text;

class CalC {
    public int add(params int[] numbers) {
        int sum = 0;
        foreach (int num in numbers) {
            sum += num;
        }
        return sum;
    }

    public void name(int age, params string[] names) {
        foreach (string name in names) {
            Console.WriteLine("Name:" + name + " " + "age:" + age);
        }
    }

    public static void averge(params double[] nums) {
        double sum = 0;
        foreach (double num in nums) {
            sum = sum + num;
        }
        Console.WriteLine("Sum:" + sum);
        Console.WriteLine("nums.Length : " + nums.Length);
        Console.WriteLine("sum / nums.Length : " + sum / nums.Length);
    }

     public static void Print(params Object[] items) {
        foreach (var item in items) {
            Console.WriteLine("items : " + item);
        }
    }
}

namespace C__Course
{
    class Params
    {
        static void Param(string[] args) {
            CalC Add = new CalC();
            int result1 = Add.add(1,2,3,4,5);
            Console.WriteLine("result 1 :" + result1);
            int result2 = Add.add(100, 2000, 30, 400, 5000);
            Console.WriteLine("result 2 :" + result2);
            int result3 = Add.add(10*50, 200, 3*100, 4, 5);
            Console.WriteLine("result 3 :" + result3);

            Add.name(19, "Dhruv", "Ayan");

            CalC.averge(100,200,300.08,400.99);

            CalC.Print(1,"Dhruv",true,99.99);
        }
    }
}