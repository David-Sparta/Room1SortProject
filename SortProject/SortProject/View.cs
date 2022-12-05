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
            char SortingMethod;
            int size;

            SortingMethod = GetUserInput.SortingMethod();

            Console.WriteLine($"Method chosen: {SortingMethod}");

            size = GetUserInput.GetSize();

            Console.WriteLine($"Array Length = {size}");

        }
    }
}
