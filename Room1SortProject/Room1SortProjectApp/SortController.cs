using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room1SortProjectApp
{
    public class SortController
    {
        public static Sort GetSort(string sortType)
        {
            sortType = sortType.ToUpper();

            switch (sortType)
            {
                case "BUBBLESORT":
                    return new BubbleSortFactory().GetInstance();
                case "MERGESORT":
                    return new MergeSortFactory().GetInstance();
                case "LIBRARY":
                    return new LibrarySortFactory().GetInstance();
                default:
                    return null;
            }
        }


    }
}
