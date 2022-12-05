using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortProject
{
    public class GetUserInput
    {
        public static int GetSize()
        {
            int answer = 0;

            while(answer <= 0)
            {
                string temp;
                Console.WriteLine("Choose an array length");
                try
                {
                    temp = Console.ReadLine();
                }
                catch(Exception)
                {
                    continue;
                }                

                if(int.TryParse(temp, out answer))
                {
                    break;
                }
            }

            return answer;
        }

        internal static char SortingMethod()
        {
            char answer = '0';
           

            while(answer != 'b' && answer != 'm' && answer != 'l')            
            {
                Console.WriteLine("Choose a Sorting Method");
                Console.WriteLine("B = BubbleSort\nM = MergeSort\nL = NET Library Sort");

                answer = Console.ReadKey().KeyChar;

            }

            return answer;            
        }
    }// end of class
}// end of namespace
