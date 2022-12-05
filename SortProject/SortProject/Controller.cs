﻿
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
            return RandomGenerator.GetRandomArray(size);
        }

        internal static int[] RequestBubbleSort(int[] array)
        {
            var bubbleSort = new BubbleSort();
            return bubbleSort.Sort(array);
        }
    }
}
