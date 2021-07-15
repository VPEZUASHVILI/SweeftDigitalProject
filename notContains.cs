using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class notContains
    {
        public void notContain1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 9 };

            Console.WriteLine(notContain(array));
            Console.ReadKey();
        }
        static int notContain(int[] array)
        {
            int num = 1;
            for (int i=0; i<array.Length; i++)
            {
                if (num==array[i])
                {
                    num++;
                    i = -1;
                    continue;
                }
            }
            return num;
        }
    }
}
