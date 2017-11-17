using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        private static MenuItem AddMenuItem()
        {
            //List<string> prompts = new List<string>(new string[4] { " the name of ", " a description of ", " the price of ", " whether it is an appetizer, main course or dessert." });

            Console.WriteLine("Please enter the name of the new item:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter a description of {0}:", name);
            string info = Console.ReadLine();
            Console.WriteLine("Please enter the price for {0}:", name);
            string price = Console.ReadLine();
            Console.WriteLine("Is {0} an appetizer, main course or dessert?", name);
            string type = Console.ReadLine();

            MenuItem newMenuItem = new MenuItem(name, info, price, type, true);
            Console.WriteLine("New menu item added.  Press 'Enter' to continue...");
            Console.ReadLine();

            return newMenuItem;
        }
    }

    public class Menu
    {
        List<MenuItem> Items { get; set; }
        DateTime LastUpdate;

        public Menu(List<MenuItem> items, DateTime lastUpdate)
        {
            this.Items = items;
            LastUpdate = lastUpdate;
        }
    }

    public class MenuItem
    {
        string Name { get; set; }
        string Info { get; set; }
        string Price { get; set; }
        string Type { get; set; }
        bool NewItem { get; set; }

        //private List<string> categories = new List<string>(new string[3]{"Appetizer", "Main Course", "Dessert"});

        public MenuItem(string name, string info, string price, string type, bool newItem = false)
        {
            this.Name = name;
            this.Info = info;
            this.Price = price;
            this.Type = type;
            this.NewItem = newItem;
        }
    }
}
