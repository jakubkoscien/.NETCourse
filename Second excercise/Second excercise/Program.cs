using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_excercise
{
     
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu();
            Order order = new Order();

            menu.AddMenuItem("Margherita", 15.5, menu.GetNextIndex(), "Pizza", "sos pomidorowy, ser");
            menu.AddMenuItem("Capricciosa", 16.5, menu.GetNextIndex(), "Pizza", "sos pomidorowy, ser, pieczarki, szynka");
            menu.AddMenuItem("Hawajska", 16.5, menu.GetNextIndex(), "Pizza" , "sos pomidorowy, ser, szynka, ananas");
            menu.AddMenuItem("Salami", 18.5, menu.GetNextIndex(), "Pizza" , "sos pomidorowy, ser, salami, oliwki");
            menu.AddMenuItem("Cztery Sery", 18.5, menu.GetNextIndex(), "Pizza" , "sos pomidorowy, gouda, parmezan, blue cheese, mozzarela");
            menu.AddMenuItem("Diabolo", 19.5, menu.GetNextIndex(), "Pizza" , "sos pomidorowy, ser, salami, cebula, papryczki pepperoni, sos tabasco");
            
            menu.AddMenuItem("W bułce", 18.5, menu.GetNextIndex(), "Kebab");
            menu.AddMenuItem("Rollo", 17.5, menu.GetNextIndex(), "Kebab");
            menu.AddMenuItem("Na talerzu", 20.5, menu.GetNextIndex(), "Kebab");
            menu.AddMenuItem("Rożek", 15.5, menu.GetNextIndex(), "Kebab");

            menu.AddMenuItem("Kotlet schabowy", 20.5, menu.GetNextIndex(), "Danie obiadowe", "kotlet, ziemniaki, surówka dnia");
            menu.AddMenuItem("Kotlet mielony", 20.5, menu.GetNextIndex(), "Danie obiadowe", "dwa kotlety, ziemniaki, surówka dnia");
            menu.AddMenuItem("Placek ziemniaczany", 20.5, menu.GetNextIndex(), "Danie obiadowe", "placek z mięsem wołowym w sosie");
            menu.AddMenuItem("Pierogi z mięsem", 18.5, menu.GetNextIndex(), "Danie obiadowe");

            menu.AddMenuItem("Cola", 7.5, menu.GetNextIndex(), "Napoje");
            menu.AddMenuItem("Fanta", 7.5, menu.GetNextIndex(), "Napoje");
            menu.AddMenuItem("Sok jabłkowy", 6.5, menu.GetNextIndex(), "Napoje");
            menu.AddMenuItem("Woda", 4.5, menu.GetNextIndex(), "Napoje");
            menu.AddMenuItem("Kawa", 6.5, menu.GetNextIndex(), "Napoje");
        
            while(true)
            {
                PrintCategories();
                int selection;


                switch (Console.ReadKey().Key)
                {

                    case ConsoleKey.D1:

                        MenuPrint(menu, "Pizza");
                        Tuple<int, int> pizzaRange = menu.GetCategoryRange("Pizza");
                        selection = Int32.Parse(Console.ReadLine());
                        if ( selection >= pizzaRange.Item1 && selection <= pizzaRange.Item2)
                        {
                            order.AddItemToOrder(menu.GetItemByIndex(selection));
                        }
                        break;

                    case ConsoleKey.D2:

                        MenuPrint(menu, "Kebab");
                        Tuple<int, int> kebabRange = menu.GetCategoryRange("Kebab");
                        selection = Int32.Parse(Console.ReadLine());
                        if (selection >= kebabRange.Item1 && selection <= kebabRange.Item2)
                        {
                            order.AddItemToOrder(menu.GetItemByIndex(selection));
                        }
                        break;

                    case ConsoleKey.D3:

                        MenuPrint(menu, "Danie obiadowe");
                        Tuple<int, int> obiadRange = menu.GetCategoryRange("Danie obiadowe");
                        selection = Int32.Parse(Console.ReadLine());
                        if (selection >= obiadRange.Item1 && selection <= obiadRange.Item2)
                        {
                            order.AddItemToOrder(menu.GetItemByIndex(selection));
                        }
                        break;

                    case ConsoleKey.D4:

                        MenuPrint(menu, "Napoje");
                        Tuple<int, int> napojeRange = menu.GetCategoryRange("Napoje");
                        selection = Int32.Parse(Console.ReadLine());
                        if (selection >= napojeRange.Item1 && selection <= napojeRange.Item2)
                        {
                            order.AddItemToOrder(menu.GetItemByIndex(selection));
                        }
                        break;

                    case ConsoleKey.D5:

                        Console.WriteLine("Podsumowanie zamówienia:");
                        order.PrintOrder();
                        Console.ReadKey();
                        break;

                       
                }
            }
        }

        static public void PrintCategories()
        {
            Console.Clear();
            Console.WriteLine("1. Pizza");
            Console.WriteLine("2. Kebab");
            Console.WriteLine("3. Danie obiadowe");
            Console.WriteLine("4. Napoje");
            Console.WriteLine("5. Podsumowanie");
        }
        static public void MenuPrint(Menu menu, string category)
        {
            Console.Clear();
            
            foreach(var item in menu.items)
            {
                if (item.Category == category)
                Console.WriteLine(item.ToString());
            }
            
        }
    }

}
