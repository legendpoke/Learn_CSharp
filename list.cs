using System;
using System.Collections.Generic;
using System.Text;

class Teacher {
    public string? name;
    public int age;
}

namespace C__Course
{
    class program_two {
        static void Lists(string[] args) {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher {name = "Dhruv",age =40});
            Console.WriteLine(teachers[0].name);
            teachers.Add(new Teacher { name = "Anmol", age = 41 });
            teachers.Add(new Teacher { name = "Ayan Abbas", age = 42 });
            teachers.RemoveAll(p => p.name == "Anmol");
            teachers.Insert(2, new Teacher
            {
                name = "Kautilya",
                age = 39
                
            });
            for (int i = 0; i < teachers.Count; i++) {
                Console.WriteLine(teachers[i].name +" "+ teachers[i].age);
            }
            //find index using condition 
            int index = teachers.FindIndex(t => t.age == 39);
            Console.WriteLine(index);
        }
    }
}
