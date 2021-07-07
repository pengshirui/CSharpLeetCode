using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy
{
    public partial class Solution
    {
        Dictionary<char, int> kv = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        public int RomanToInt(string s)
        {
            var result = 0;
            for (var i = 0; i < s.Length; i++)
            {
                if (i + 1 == s.Length)
                {
                    // last index
                    result += kv[s[i]];
                }
                else if (kv[s[i]] < kv[s[i + 1]])
                {
                    result -= kv[s[i]];
                }
                else
                {
                    result += kv[s[i]];
                }

            }
            return result;
        }
    }
}
