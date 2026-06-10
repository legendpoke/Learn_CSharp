using System;
using System.Collections.Generic;
using System.Text;

namespace C__Course
{
    class Other_Collections
    {
        static void OtherCollections(string[] args) {
            Queue<string> players = new Queue<string>();

            players.Enqueue("Dhruv");
            players.Enqueue("Rahul");

            Console.WriteLine("Dequeue Players:"+players.Dequeue());
            foreach (var items in players) {
                Console.WriteLine("items_queue:" + items);
            }



            Stack<int> numbers = new Stack<int>();

            numbers.Push(10);
            numbers.Push(20);

            Console.WriteLine("poped numbers"+numbers.Pop());
            foreach (var items in numbers)
            {
                Console.WriteLine("items_Stack:" + items);
            }



            HashSet<int> nums = new HashSet<int>();

            nums.Add(10);
            nums.Add(20);

            Console.WriteLine("HashSet Count:"+nums.Count);
            foreach (var items in nums)
            {
                Console.WriteLine("items_HashSet:" + items);
            }



            LinkedList<int> num = new LinkedList<int>();

            num.AddLast(10);
            num.AddLast(20);
            num.AddFirst(5);
            foreach (var items in num)
            {
                Console.WriteLine("items_LinkedList:" + items);
            }

            SortedList<int, string> students = new SortedList<int, string>();

            students.Add(3, "C");
            students.Add(1, "A");
            students.Add(2, "B");
            foreach (var items in students)
            {
                Console.WriteLine("items_SortedList:" + items);
            }
        }
    }
}
