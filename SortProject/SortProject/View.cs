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
            var array = Controller.RequestArray(size);

            Console.WriteLine("Unsorted Array:");
            RandomGenerator.show(array);

            // get time
            long timeBefore, timeAfter, lengthOfTime;
            
            timeBefore = DateTime.Now.Ticks;

            if (SortingMethod == 'b')
            {
                Controller.RequestBubbleSort(array);
            }
            
            timeAfter = DateTime.Now.Ticks;

            lengthOfTime = timeAfter - timeBefore;            

            TimeSpan duration = new TimeSpan(lengthOfTime);
            double seconds = duration.TotalMinutes;

            Console.WriteLine("Sorted Array:");
            RandomGenerator.show(array);

            Console.WriteLine($"The sorting algorithm took {seconds} to complete.");
        }
    }
}
