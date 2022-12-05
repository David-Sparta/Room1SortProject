using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class View
    {
        SortAlgorithm _sortAlgorithm;

        SortAlgorithm SortAlgorithm
        {
            get
            {
                return _sortAlgorithm;
            }
            set
            {
                _sortAlgorithm = value;
            }
        }

        public View(SortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        static void Main(string[] args)
        {
            // get user input
            char SortingMethod = GetUserInput.SortingMethod();
            int size = GetUserInput.GetSize();

            //var arr = new int[size];

            var arr = RandomGenerator.GetRandomArray(size);

            RandomGenerator.show(arr);

            

        }
    }
}
