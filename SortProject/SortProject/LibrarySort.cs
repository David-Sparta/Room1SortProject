using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class LibrarySort : SortAlgorithm
    {
        public LibrarySort() 
        {
            
        }

        public override int[] Sort(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
