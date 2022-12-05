using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class Controller
    {
        SortAlgorithm _sortAlgorithm;
        View _view;

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

        View View
        {
            get
            {
                return _view;
            }
            set
            {
                _view = value;
            }
        }

        public Controller(SortAlgorithm sortAlgorithm, View view)
        {
            _sortAlgorithm = sortAlgorithm;
            _view = view;
        }

        internal static int[] RequestArray(int size)
        {
            //Get Random Array of Size
            return new int[size]; // Inimplemented
        }
    }
}
