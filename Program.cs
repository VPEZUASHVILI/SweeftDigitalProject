using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string content = "civic";
            if(isPalindrome(content)==true)
            {
                Console.WriteLine("is palindrome");

            }
            else
            {
                Console.WriteLine("is not palindrome");
            }

                  
            Console.ReadKey();
        }
        static Boolean isPalindrome(string content)
        {
            int length = content.Length;

            int half = length / 2;

            int isOddLength = length % 2;

           
            int j = (isOddLength == 0) ? half : half + 1;

            for (int i = half - 1; i >= 0; i--)
            {
                if (content[i] != content[j])
                {
                    return false;
                }
                j++;

            }
            return true;
            
        }
    }
}
