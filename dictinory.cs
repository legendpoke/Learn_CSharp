using System;
using System.Collections.Generic;
using System.Text;

class Data {
    public string? name;
    public int age;
}

namespace C__Course
{
    class D_ictinory
    {
        static void dictinory(string[] args) {
            Dictionary<int,string> students = new Dictionary<int, string>() {
                {1,"Dhruv"},
                {2,"Ayan"}
            };
            students.Add(3,"Kautiya");
            foreach (var item in students) {
                Console.WriteLine("keys:"+item.Key);
                Console.WriteLine("Values:"+item.Value);
            }
            students[2] = "Anmol";
            Console.WriteLine("Count:"+students.Count);
            if (students.ContainsKey(1)) {
                Console.WriteLine("Found");
            }

            if (students.ContainsValue("Ayan")) {
                Console.WriteLine("Found");
            }

            if (students.TryGetValue(2, out string? name)) {
                Console.WriteLine("Name:"+name);
            }

            Dictionary<int, Data> data = new Dictionary<int, Data>() { };
            Data d = new Data();
            d.name = "Su-ho";
            d.age = 19;
            data.Add(5,d);
            foreach (var item in data) {
                Console.WriteLine("keys:" + item.Key);
                Console.WriteLine("Values_Age:" + item.Value.age);
                Console.WriteLine("Values_Name:" + item.Value.name);
                Console.WriteLine("Values:" + item.Value);
            }
        }
    }
}
