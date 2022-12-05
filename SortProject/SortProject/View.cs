using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject {
    public class View {
        SortAlgorithm _sortAlgorithm;

        SortAlgorithm SortAlgorithm {
            get {
                return _sortAlgorithm;
            }
            set {
                _sortAlgorithm = value;
            }
        }

        public View( SortAlgorithm sortAlgorithm ) {
            _sortAlgorithm = sortAlgorithm;
        }

        static void Main( string[] args ) {
            // get user input
            char SortingMethod = GetUserInput.SortingMethod();
            if ( SortingMethod == 'm' ) {

                int size1 = GetUserInput.GetSize();
                int size2 = GetUserInput.GetSize();

                var arr1 = Controller.RequestArray( size1 );
                var arr2 = Controller.RequestArray( size2 );

                var sortedArr = Controller.RequestSort( arr1, arr2 );


                Console.WriteLine( "Array 1" );
                RandomGenerator.show( arr1 );
                Console.WriteLine();
                Console.WriteLine( "Array 2" );
                RandomGenerator.show( arr2 );
                Console.WriteLine();
                Console.WriteLine( "Sorted Array" );
                RandomGenerator.show( sortedArr );

            }
            else {
                int size = GetUserInput.GetSize();

                //var arr = new int[size];
                var array = Controller.RequestArray( size );

                Console.WriteLine( "Unsorted Array:" );
                RandomGenerator.show( array );

                // get time
                long timeBefore, timeAfter, lengthOfTime;

                timeBefore = DateTime.Now.Ticks;

                if ( SortingMethod == 'b' ) {
                    Controller.RequestBubbleSort( array );
                }
                else if ( SortingMethod == 'm' ) {

                }
                else if ( SortingMethod == 'l' ) {
                    Controller.RequestLibrarySort( array );
                }

                timeAfter = DateTime.Now.Ticks;

                lengthOfTime = timeAfter - timeBefore;

                TimeSpan duration = new TimeSpan( lengthOfTime );
                double seconds = duration.TotalMinutes;

                Console.WriteLine( "Sorted Array:" );
                RandomGenerator.show( array );

                Console.WriteLine( $"The sorting algorithm took {seconds} to complete." );
            }
        }
    }
}
