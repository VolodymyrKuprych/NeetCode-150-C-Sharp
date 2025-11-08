using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P04_GroupAnagrams_LC49
{
    public class GroupAnagramsMySolution
    {
        public List<List<string>> GroupAnagrams(string[] strs)
        {
            var res = new Dictionary<string, List<string>>();

            foreach (var s in strs)
            {
                char[] charArray = s.ToCharArray();
                Array.Sort(charArray);
                string sortedS = new string(charArray);

                if (!res.ContainsKey(sortedS))
                {
                    res[sortedS] = new List<string>();
                }

                res[sortedS].Add(s);
            }

            return res.Values.ToList<List<string>>();
        }
    }
}
