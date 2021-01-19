using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create linked list
            var list = new Model.LinkedList<int>();

            // Add data to list
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Show list
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            //Delete element from list
            list.Delete(3);

            // Show list
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Add new element to head of list
            list.AppendHead(7);

            // Show list
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Insert new element after target element
            list.InsertAfter(4, 77);

            // Show list
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();










            Console.ReadLine();
        }
    }
}
