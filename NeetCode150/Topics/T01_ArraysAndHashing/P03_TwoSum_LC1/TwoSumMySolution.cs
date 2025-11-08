using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P03_TwoSum_LC1
{
    public  class TwoSumMySolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new();

            for (int i = 0; i < nums.Length; i++) 
            {
                int x = target - nums[i];

                if (map.ContainsKey(x))
                {
                    return new int[] { map[x], i };
                } 
                else
                {
                    map.Add(nums[i], i);
                }
            }

            throw new Exception();
        }
    }
}
