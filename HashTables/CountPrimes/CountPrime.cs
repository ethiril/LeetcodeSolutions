using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.HashTables.CountPrimes
{
    class CountPrime
    {
        public int CountPrimes(int n)
        {

            // Sieve of Eratosthenes
            // assume all numbers are prime, 
            // remove multiples of these numbers if they are prime 
            // move to next prime and repeat
            bool[] notPrime = new bool[n];
            int count = 0;
            for (int i = 2; i < n; i++)
            {
                if (!notPrime[i])
                {
                    count++;
                    for (int j = i; j <= (n - 1) / i; j++)
                    {
                        int v = i * j;
                        notPrime[v] = true;
                    }
                }
            }
            return count;
        }
    }
}
