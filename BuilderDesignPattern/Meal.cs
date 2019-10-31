using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class Meal
    {
        private IList<Item> items = new List<Item>();
        public void addItem(Item item)
        {
            items.Add(item);
        }
        public float getCost()
        {
            float cost = 0.0f;

            foreach (Item item in items)
            {
                cost += item.price();
            }
            return cost;
        }

        public void showItems()
        {
            foreach (Item item in items)
            {
                Console.Write("Item : " + item.name());
                Console.Write(", Packing : " + item.packing().pack());
                Console.WriteLine(", Price : " + item.price());
            }
        }
    }
}
