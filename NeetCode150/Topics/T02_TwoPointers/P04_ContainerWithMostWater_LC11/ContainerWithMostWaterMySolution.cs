using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T02_TwoPointers.P04_ContainerWithMostWater_LC11
{
    public  class ContainerWithMostWaterMySolution
    {
        public int MaxArea(int[] heights)
        {
            int res = 0;
            int l = 0, r = heights.Length - 1;

            while (l < r)
            {
                int area = (Math.Min(heights[l], heights[r])) * (r - l);
                res = Math.Max(area, res);

                if (heights[l] <= heights[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
            return res;
        }
    }
}
