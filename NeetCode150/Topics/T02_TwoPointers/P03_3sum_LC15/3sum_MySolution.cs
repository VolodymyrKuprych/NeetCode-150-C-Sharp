using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T02_TwoPointers.P03_3sum_LC15
{
    public class _3sum_MySolution
    {
        public List<List<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            List<List<int>> res = new List<List<int>>();

            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i] == nums[i - 1]) continue;

                int l = i + 1, r = nums.Length - 1;
                while (l < r)
                {
                    int sum = nums[i] + nums[l] + nums[r];
                    if (sum > 0)
                    {
                        r--;
                    }
                    else if (sum < 0)
                    {
                        l++;
                    }
                    else
                    {
                        res.Add(new List<int> { nums[i], nums[l], nums[r] });
                        l++;
                        r--;
                        while (l < r && nums[l] == nums[l - 1])
                        {
                            l++;
                        }
                    }
                }
            }
            return res;
        }
    }
}
