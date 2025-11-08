using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DSA.NeetCode150.Topics.T01_ArraysAndHashing.P06_EncodeAndDecodeStrings_LC271p
{
    public  class EncodeAndDecodeStringMySolution
    {
        public string Encode(IList<string> strs)
        {
            if (strs.Count() == 0)
            {
                return "";
            }

            StringBuilder res = new();

            foreach (string str in strs) 
            { 
                res.Append(str.Length).Append(',');
            }
            res.Remove(res.Length - 1, 1);
            res.Append(";");

            foreach (string str in strs)
            {
                res.Append(str);
            }

            return res.ToString();
        }

        public List<string> Decode(string s)
        {
            if (s == "")
            {
                return new List<string> { };
            }

            var parts = s.Split(";");
            var sizes = parts[0].Split(",").Select(int.Parse).ToList();
            var res = new List<string>();
            var i = 0;

            foreach (var size in sizes)
            {
                res.Add(parts[1].Substring(i,size));
                i += size;      
            }

            return res;
        }
    }
}
