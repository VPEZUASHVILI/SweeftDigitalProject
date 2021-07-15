using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Palindrome
{
    class Task5
    {
        public void climbingStairs()
        {
            int n = 7;
            Console.WriteLine(countVariant(n));
            Console.ReadKey();
        }
        public static long factorial(long number)
        {
            long result = 1;
            for (int factor = 2; factor <= number; factor++)
            {
                result *= factor;
            }
            return result;
        }
        static int countVariant(int n)
        {
            long count = 1;
            long temp = 0;
            for ( int i=1; i<=n/2; i++)
            {
                temp = factorial(n - 1) / (factorial(i) * factorial(n - i * 2));
                count += temp;
            }
            int count1 = Convert.ToInt32(count);
            return count1;
        }

    }
    

}

