using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room1SortProjectApp
{
    public abstract class SortFactory
    {
        public abstract Sort GetInstance();
    }

    public class BubbleSortFactory : SortFactory
    {
        public override Sort GetInstance()
        {
            return new BubbleSort();
        }
    }

    public class MergeSortFactory : SortFactory
    {
        public override Sort GetInstance() 
        {        
            return new MergeSort();
        }
    }

    public class LibrarySortFactory : SortFactory
    {

        public override Sort GetInstance()
        {
            return new LibrarySort();
        }
    }
}
