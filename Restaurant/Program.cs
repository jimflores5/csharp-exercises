using System;
using System.Collections.Generic;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MenuItem> menu = new List<MenuItem>();
            bool repeat = false;

            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine("Time to add a menu item!");
                Console.ReadLine();
                MenuItem newFood = AddMenuItem();

                foreach (MenuItem entry in menu)
                {
                    if (newFood.Equals(entry))
                    {
                        Console.WriteLine("Sorry, " + newFood + " is already on the menu.");
                        repeat = true;
                    }
                }
                if (!repeat)
                {
                    menu.Add(newFood);
                }   
            }

            Console.WriteLine("Now let's print the menu...");
            Console.ReadLine();

            foreach (MenuItem item in menu)
            {
                Console.WriteLine(item.Name + ": " + item.Info);
            }
            Console.ReadLine();
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
        public string Name { get; set; }
        public string Info { get; set; }
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

        public override bool Equals(Object obj)
        {
            if (obj == null) //check for null case
            {
                return false;
            }
            MenuItem menuItem = (MenuItem)obj;  // cast obj to MenuItem
            return this.Name == menuItem.Name && this.Type == menuItem.Type; //check for value equality and return a bool.
        }
    }
}
