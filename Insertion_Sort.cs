using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class Insertion_Sort
    {
        public static void Sorting(string[] word)
        {
            int n = word.Length;
            for(int i=1; i<n; ++i) 
            {
                string position = word[i];
                int j=i-1;
                while(j>=0 && word[j].CompareTo(position)>0) 
                {
                    word[j+1] = word[j];
                    j = j - 1;
                }
                word[j + 1] = position;
            }
        }
    }
}
