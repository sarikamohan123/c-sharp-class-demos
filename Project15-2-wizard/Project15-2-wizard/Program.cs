using System;
using System.Collections.Generic;

   class WizardInventory
{
    static void Main()
    {
        List<string> inventory = new List<string> { "wooden staff", "wizard hat", "cloth shoes" };
        const int maxItems = 4;

        while (true)
        {
            Console.WriteLine("\nCOMMAND MENU");
            Console.WriteLine("show - Show all items");
            Console.WriteLine("grab - Grab an item");
            Console.WriteLine("edit - Edit an item");
            Console.WriteLine("drop - Drop an item");
            Console.WriteLine("exit - Exit program");
            Console.Write("\nCommand: ");
            string command = Console.ReadLine().ToLower();

            if (command == "show")
            {
                ShowItems(inventory);
            }
            else if (command == "grab")
            {
                GrabItem(inventory, maxItems);
            }
            else if (command == "edit")
            {
                EditItem(inventory);
            }
            else if (command == "drop")
            {
                DropItem(inventory);
            }
            else if (command == "exit")
            {
                Console.WriteLine("Bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid command. Please try again.");
            }
        }
    }

    static void ShowItems(List<string> inventory)
    {
        for (int i = 0; i < inventory.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {inventory[i]}");
        }
    }

    static void GrabItem(List<string> inventory, int maxItems)
    {
        if (inventory.Count >= maxItems)
        {
            Console.WriteLine("You can't carry any more items. Drop something first.");
        }
        else
        {
            Console.Write("Name: ");
            string itemName = Console.ReadLine();
            inventory.Add(itemName);
            Console.WriteLine($"{itemName} was added.");
        }
    }

    static void EditItem(List<string> inventory)
    {
        Console.Write("Number: ");
        if (int.TryParse(Console.ReadLine(), out int itemNumber) && itemNumber > 0 && itemNumber <= inventory.Count)
        {
            Console.Write("Updated name: ");
            string updatedName = Console.ReadLine();
            inventory[itemNumber - 1] = updatedName;
            Console.WriteLine($"Item number {itemNumber} was updated.");
        }
        else
        {
            Console.WriteLine("Invalid item number.");
        }
    }

    static void DropItem(List<string> inventory)
    {
        Console.Write("Number: ");
        if (int.TryParse(Console.ReadLine(), out int itemNumber) && itemNumber > 0 && itemNumber <= inventory.Count)
        {
            string droppedItem = inventory[itemNumber - 1];
            inventory.RemoveAt(itemNumber - 1);
            Console.WriteLine($"{droppedItem} was dropped.");
        }
        else
        {
            Console.WriteLine("Invalid item number.");
        }
    }
}
