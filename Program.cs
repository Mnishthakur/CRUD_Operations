using System;
using System.Collections;
namespace CRUD_oprations;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList();

        // Add items
        list.Add("Apple");
        list.Add("Banana");
        list.Add("Cherry");

        // Read items
        Console.WriteLine("Items in the list:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }

        // Update an item
        list[1] = "Mango";

        // Delete an item
        list.RemoveAt(0);

        // Read items after update and delete
        Console.WriteLine("\nUpdated items in the list:");
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
}
