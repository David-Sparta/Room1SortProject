using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            int SortingMethod = GetUserInput.SortingMethod();
            int size = GetUserInput.GetSize();
        }
    }
}
