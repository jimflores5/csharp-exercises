using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.Models
{
    public class CheeseData
    {
        static private List<Cheese> cheeseList = new List<Cheese>();

        public static List<Cheese> GetAll()
        {
            return cheeseList;
        }

        public static void Add(Cheese newCheese)
        {
            cheeseList.Add(newCheese);
        }

        public static void Remove(int id)
        {
            Cheese eaten = GetById(id);
            cheeseList.Remove(eaten);
        }

        public static Cheese GetById(int id)
        {
            return cheeseList.Single(x => x.CheeseId == id);
        }
    }
}
