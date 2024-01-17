using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Fibonacci
    {
        public int[] Cache;
        public int _limit = 0;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n"> 피보나치 수열 합 </param>
        /// 
        public int Get(int n) 
        {
            _limit = n;
            Cache = new int[n + 1];
            return F(n);
        }

        // F(n) = F(n-1) + F(n-2)
        private int F(int n)
        {
            if (n <= 0) 
            {
                return n = 0;
            }

            if (Cache[n] > 0)
                return Cache[n];


            Cache[n] = F(n - 1) + F(n - 2);
            return Cache[n];
        }

    }
}
