using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class minSplit
    {
        public void minsplit()
        {
            int money = 133;
            Console.WriteLine(coinAmount(money));
            Console.ReadKey();
        }
        static int coinAmount(int money)
        {
            int[] array = new int[] { 50, 20, 15, 10, 5, 1 };
            int amount = 0;
            for (int i=0; i<array.Length; i++)
            {
                amount += money / array[i];
                money = money % array[i];

            }
            return amount;
        }
    }
}
