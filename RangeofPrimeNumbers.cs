using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_Algorithms
{
    public class RangeofPrimeNumbers
    {
        public static void Prime()
        {
                int n = 1000;
                for (int i = 2; i <= n; i++)
                {
                    bool isPrime = true;
                    for (int j = 2; j <= Math.Sqrt(i); j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                        Console.Write(i + " ");
                }
            
        }

    }
}
