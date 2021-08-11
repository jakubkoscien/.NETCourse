using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_List
{
    class Sorting
    {
        
        public List<int> MyList = new List<int>();
        
        public void GetList()
        {
            bool live = true;
            while (live)
            {
                int number;
                Console.WriteLine("Podaj liczbę do listy lub wpisz e jeśli chcesz zakończyć wpisywanie");

                string input = Console.ReadLine();

                if (input == "e")
                {
                    live = false;
                }
                else
                {

                    bool success = Int32.TryParse(input, out number);

                    if (success)
                    {
                        MyList.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Podaj poprawne dane!");
                    }
                }
            }
        }

        public List<int> SortAsc(List<int> MyList)
        {
            List<int> MySortedList = new List<int>();
            while (MyList.Count > 0)
            {
                int MinInt = int.MaxValue;
                int index = 0;

                for (var i = 0; i < MyList.Count; i++)
                {
                    if (MyList[i] <= MinInt)
                    {
                        MinInt = MyList[i];
                        index = i;
                    }

                }

                MySortedList.Add(MyList[index]);
                MyList.RemoveAt(index);

            }

            return MySortedList;
        }

        public void ResultView(List<int> MySortedList)
        {
            foreach (var item in MySortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
