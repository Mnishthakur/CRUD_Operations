using System;
using System.Collections.Generic;
namespace CRUD_oprations;

class Program
{
    static void Main()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        // Add items
        dictionary.Add(1, "Apple");
        dictionary.Add(2, "Banana");
        dictionary.Add(3, "Cherry");

        // Read items
        Console.WriteLine("Items in the dictionary:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }

        // Update an item
        dictionary[2] = "Mango";

        // Delete an item
        dictionary.Remove(1);

        // Read items after update and delete
        Console.WriteLine("\nUpdated items in the dictionary:");
        foreach (var kvp in dictionary)
        {
            Console.WriteLine(kvp.Key + ": " + kvp.Value);
        }
    }
}
