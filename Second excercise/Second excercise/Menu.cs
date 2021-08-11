using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_excercise
{
    class Menu
    {
        public List<MenuItem> items;

        public Menu()
        {
            items = new List<MenuItem>();
        }

        public void AddMenuItem(string name, double price, int index, string category, string ingredients)
        {
            MenuItem newMenuItem = new MenuItem( name,  price,  index,  category,  ingredients);
            items.Add(newMenuItem);
        }

        public void AddMenuItem(string name, double price, int index, string category)
        {
            MenuItem newMenuItem = new MenuItem(name, price, index, category);
            items.Add(newMenuItem);
        }

        public int GetNextIndex()
        {
            return items.Count + 1;
        }

        public MenuItem GetItemByIndex(int index)
        {
            foreach (var item in items)
            {
                if (item.Index == index)
                {
                    return item;
                }

            }

            return null;
        }

        public Tuple<int,int> GetCategoryRange(string category)
        {
            int startIndex = 999;
            int endIndex = 0;

            foreach (var item in items)
            {
                if(item.Category == category)
                {
                    if (startIndex > item.Index)
                        startIndex = item.Index;
                    if (endIndex < item.Index)
                        endIndex = item.Index;
                }
            }

            Tuple<int, int> tuple = new Tuple<int, int>(startIndex,endIndex);
            return tuple;
        }
    }
}
