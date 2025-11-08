using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P01_ContainsDuplicate_LC217
{
    public class ContainsDuplicateMyVersion
    {
        public bool hasDuplicate(int[] nums)
        {
            return new HashSet<int>(nums).Count != nums.Length;
        }
    }
}
