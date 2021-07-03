using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.ArraysAndStrings
{
    public partial class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var dictionary = new Dictionary<string, IList<string>>();
            foreach (var str in strs)
            {
                var hs = GetHash(str);
                if (dictionary.TryGetValue(hs, out var list))
                {
                    list.Add(str);
                }
                else
                {
                    dictionary[hs] = new List<string> { str };
                }
            }
            return dictionary.Values.ToList();
        }

        private string GetHash(string str)
        {
            var counting = new int[26];
            foreach (var c in str)
            {
                counting[c - 'a']++;
            }
            var sb = new StringBuilder();
            for (var i = 0; i < counting.Length; i++)
            {
                while (counting[i] > 0)
                {
                    counting[i]--;
                    sb.Append((char)(i + 'a'));
                }
            }
            return sb.ToString();
        }
    }
}
