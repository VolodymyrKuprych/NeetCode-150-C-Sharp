using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T02_TwoPointers.P02_TwoSum2InputArrayIsSorted_LC167
{
    public class TwoSum2MySolution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length == 2)
            {
                return new int[] { 1, 2 };
            }

            int l = 0, r = 1;

            while (r < numbers.Length) 
            {
                var sum = numbers[l] + numbers[r];

                if (sum  < target)
                {
                    l++;
                    r++;
                } 
                else if (sum > target)
                {
                    l--;
                }
                else
                {
                    return new int[]{ l + 1, r + 1};
                }
            }

            throw new Exception();
        }
    }
}
