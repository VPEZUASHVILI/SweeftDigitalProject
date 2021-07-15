using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Task4
    {
        public void properely()
        {
            string str = Console.ReadLine();
            Console.WriteLine(isProperely(str));
            Console.ReadKey();

        }
        static Boolean isProperely(string str)
        {
            int opCount = 0;
            int clsCount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char s = Convert.ToChar(str[i]);
                if (s == '(')
                {
                    opCount++;
                }
                else
                {
                    clsCount++;
                }
                if (opCount < clsCount)
                    return false;
            }
            if (opCount != clsCount)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
