using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T02_TwoPointers.P01_ValidPalindrome_LC125
{
    public class ValidPalindromeMySolution
    {
        public bool IsPalindrome(string s)
        {
            var str = new String(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            int l = 0;
            int r = str.Length -  1;

            while (l < r) 
            {
                if (str[l] != str[r])
                {
                    return false;
                }

                l++;
                r--;
            }

            return true;
        }
    }
}
