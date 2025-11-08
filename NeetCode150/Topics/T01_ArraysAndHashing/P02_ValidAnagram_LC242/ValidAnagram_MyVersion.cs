using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P02_ValidAnagram_LC242
{
    public class ValidAnagram_MyVersion
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            Dictionary<char, int> sMap = new();

            foreach (char c in s) 
            {
                if (sMap.ContainsKey(c))
                {
                    sMap[c]++;
                }
                else
                {
                    sMap.Add(c, 1);
                }
            }

            foreach (char c in t) 
            {
                if (sMap.ContainsKey(c) && sMap[c] > 0)
                {
                    sMap[c]--;
                } 
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
