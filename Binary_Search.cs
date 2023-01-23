using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class Binary_Search
    {
        public static int Search(string[] word, string item)
        {
            int lowervalue = 0;
            int highervalue = word.Length - 1;
            while(lowervalue<=highervalue)
            {
                int mid = (lowervalue + highervalue) / 2;
                if (word[mid].CompareTo(item)==0)
                {
                    return mid;
                }
                else if (word[mid].CompareTo(item) < 0)
                {
                    lowervalue = mid + 1;
                }
                else 
                {
                    highervalue = mid - 1;
                }
            }
            return -1;
        }
    }
}
