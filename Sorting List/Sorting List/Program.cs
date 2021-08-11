using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_List
{
    class Program
    {
        static void Main(string[] args)
        {

            Sorting sorting = new Sorting();

            sorting.GetList();
            Console.WriteLine("Twoja lista:");
            sorting.ResultView(sorting.MyList);
            List<int> SortedList = sorting.SortAsc(sorting.MyList);
            Console.WriteLine("Posortowana lista:");
            sorting.ResultView(SortedList);
            Console.ReadLine();

        }
    }
}
