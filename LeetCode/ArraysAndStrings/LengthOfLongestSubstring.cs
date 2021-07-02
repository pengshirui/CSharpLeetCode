using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.ArraysAndStrings
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            var maxLength = 0;
            var curSubstr = string.Empty;

            for (var i = 0; i < s.Length; i++)
            {
                // find dup
                var index = curSubstr.IndexOf(s[i]);
                if (index != -1)
                {
                    if (index + 1 < curSubstr.Length)
                    {
                        curSubstr = curSubstr.Substring(index + 1);
                        curSubstr += s[i];
                    }
                    else
                    {
                        curSubstr = s[i].ToString();
                    }
                }
                else
                {
                    curSubstr += s[i];
                    maxLength = curSubstr.Length > maxLength ? curSubstr.Length : maxLength;
                }
            }
            return maxLength;
        }
    }
}
