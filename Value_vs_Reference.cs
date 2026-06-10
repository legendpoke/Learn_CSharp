using System;
using System.Collections.Generic;
using System.Text;

// CLASS = Reference Type
// Objects of classes are stored in HEAP memory.
// Variables store reference/address of object.

class Person
{
    // Default value of Name
    public string Name = "Unknown";
}


// Demonstrating VALUE TYPE passing
class Change
{
    // x receives COPY of value
    public static void change(int x)
    {
        x = 100;

        // Only local copy changes
        // Original variable will remain same
    }
}


// Another class = Reference Type
class Player_P
{
    public int hp;

    // p receives COPY of reference
    // Both references point to SAME object
    public static void change(Player_P p)
    {
        p.hp = 100;

        // Original object's hp changes
    }
}


namespace C__Course
{
    class Value_vs_Reference
    {
        static void Value_Reference(string[] args)
        {

            // =====================================================
            // DEFAULT VALUE IN OBJECT
            // =====================================================

            // Creating object of Person class
            Person p0 = new Person();

            // Accessing default value
            string result = p0.Name;

            Console.WriteLine("result : " + result);

            // Changing Name value
            p0.Name = "hii";

            Console.WriteLine("p0.Name : " + p0.Name);



            // =====================================================
            // REFERENCE TYPE BEHAVIOR
            // =====================================================

            // Creating another object
            Person p1 = new Person();

            // Assigning value
            p1.Name = "Dhruv";

            Console.WriteLine("p1.Name : " + p1.Name);


            // p2 DOES NOT create new object
            // p2 and p1 both point to SAME object
            Person p2 = p1;

            // Changing using p2
            p2.Name = "RayMond Luis";

            // Since both point to same object,
            // p1 value also changes
            Console.WriteLine("p1.Name after p2 : " + p1.Name);

            Console.WriteLine("p2.Name : " + p2.Name);



            // =====================================================
            // VALUE TYPE BEHAVIOR
            // =====================================================

            // int is VALUE TYPE
            int a = 10;

            Console.WriteLine("a : " + a);


            // COPY happens here
            int b = a;

            // Changing b
            b = 20;

            // a remains unchanged
            Console.WriteLine("a after b : " + a);

            // Changing a
            a = 40;

            Console.WriteLine("a changed value : " + a);

            // b remains same
            Console.WriteLine("b : " + b);



            // =====================================================
            // PASSING VALUE TYPE TO METHOD
            // =====================================================

            int d = 200;

            // COPY of d goes into x
            Change.change(d);

            // Original d unchanged
            Console.WriteLine("d : " + d);



            // =====================================================
            // PASSING REFERENCE TYPE TO METHOD
            // =====================================================

            // Creating object
            Player_P play = new Player_P();

            play.hp = 400;

            // Reference copy passed
            Player_P.change(play);

            // Printing object directly
            // Default output = namespace.classname
            Console.WriteLine("play : " + play);

            // hp changed because object itself changed
            Console.WriteLine("player hp : " + play.hp);



            // =====================================================
            // OBJECT KEYWORD
            // =====================================================

            // object can store any datatype
            object age = 19;

            Console.WriteLine("Age : " + age);


            // Object and object are same
            Object Name = "Dhruv";

            Console.WriteLine("Name : " + Name);



            // =====================================================
            // FINAL SUMMARY
            // =====================================================

            /*
             
             VALUE TYPE:
             - Stores actual value
             - Example: int, float, double, bool
             - Copy creates separate variable

             REFERENCE TYPE:
             - Stores reference/address
             - Example: class, object, string, array
             - Copy points to same object

             METHOD PASSING:
             - Value type => copy of value
             - Reference type => copy of reference

            */
        }
    }
}