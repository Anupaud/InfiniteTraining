//4.Create a simple Stationery application to add items and display added items using Generic List collections.

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment06
{
    class Stationery
    {
        static void Main(string[] args)
        {
            List<string> stationeryItems = new List<string>();
            stationeryItems.Add("NoteBooks");
            stationeryItems.Add("Pen");
            stationeryItems.Add("Pencil");

            Console.WriteLine("Items are:");
            foreach (string items in stationeryItems)
            {
                Console.WriteLine(items);
            }
            Console.ReadKey();
        }
    }
}
