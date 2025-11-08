using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P09_LongestConsecutiveSequence_LC128
{
    public class LongestConsecutiveSequenceMySolution
    {
        public int LongestConsecutive(int[] nums)
        {
            HashSet<int> numSet = new HashSet<int>(nums);
            int longest = 0;

            foreach (int num in numSet)
            {
                if (!numSet.Contains(num - 1))
                {
                    int length = 1;
                    while (numSet.Contains(num + length))
                    {
                        length++;
                    }
                    longest = Math.Max(longest, length);
                }
            }
            return longest;
        }
    }
}
