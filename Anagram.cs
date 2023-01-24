using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class Anagram
    {
        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }
            
            s1 = String.Concat(s1.ToLower().OrderBy(c => c));
            s2 = String.Concat(s2.ToLower().OrderBy(c => c));
            
            return s1.Equals(s2);
        }
    }
}
