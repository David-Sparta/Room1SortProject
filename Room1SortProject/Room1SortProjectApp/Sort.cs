using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room1SortProjectApp
{
    public abstract class Sort
    {
        public abstract string MakeSorted();
    }

    public class BubbleSort : Sort
    {
        public override string MakeSorted()
        {
            return "Sorted - via the bubblesort method";
        }
    }

    public class MergeSort : Sort
    {
        public override string MakeSorted()
        {
            return "Sorted - via the mergesort method";
        }
    }

    public class LibrarySort : Sort
    {
        public override string MakeSorted()
        {
            return "Sorted - via the mergesort method";
        }
    }
}
