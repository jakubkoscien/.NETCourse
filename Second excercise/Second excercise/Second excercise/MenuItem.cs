using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_excercise
{
    class MenuItem
    {
        public string Name { get; }
        public double Price { get; }
        public int Index { get; }
        public string Category { get; }
        public string Ingredients { get; }

        public MenuItem(string name, double price, int index, string category, string ingredients)
        {
            Name = name;
            Price = price;
            Index = index;
            Category = category;
            Ingredients = ingredients;
        }

        public MenuItem(string name, double price, int index, string category)
        {
            Name = name;
            Price = price;
            Index = index;
            Category = category;
            Ingredients = string.Empty;
        }


        public override string ToString()
        {
            string itemString = "";

            itemString += Index +". ";
            itemString += Name;
            if(Ingredients.Length > 0)
            {
                itemString += " - " + Ingredients;
            }
            itemString += " " + Price.ToString();

            return itemString;
        }

    }
}
