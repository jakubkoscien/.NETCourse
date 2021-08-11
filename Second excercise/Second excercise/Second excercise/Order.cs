using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_excercise
{
    class Order
    {
        public List<MenuItem> orderedItems;

        public double Sum;
        public Order()
        {
            Sum = 0;
            orderedItems = new List<MenuItem>();
        }

        public void PrintOrder()
        {
            Console.Clear();
            Console.WriteLine("Order:");
            foreach(var item in orderedItems)
            {
                Console.WriteLine(item.Name + " " + item.Price.ToString());
            }
            Console.WriteLine("Suma w zł " + Sum);
        }

        public void AddItemToOrder(MenuItem item)
        {
            orderedItems.Add(item);
            Sum += item.Price;
        }
    }
}
