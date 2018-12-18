/// <summary>
/// https://leetcode.com/problems/backspace-string-compare
/// </summary>
namespace LeetCode.Easy
{
    public partial class Solution
    {
        public bool BackspaceCompare(string S, string T)
        {
            var i = S.Length - 1;
            var j = T.Length - 1;
            var skipS = 0;
            var skipT = 0;
            while (i >= 0 || j >= 0)
            {
                while (i >= 0)
                {
                    if (S[i] == '#')
                    {
                        skipS++;
                        i--;
                    }
                    else if (skipS > 0)
                    {
                        skipS--;
                        i--;
                    }
                    else
                    {
                        break;
                    }
                }

                while (j >= 0)
                {
                    if (T[j] == '#')
                    {
                        skipT++;
                        j--;
                    }
                    else if (skipT > 0)
                    {
                        skipT--;
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
                if (i >= 0 && j >= 0 && S[i] != T[j])
                {
                    return false;
                }
                if ((i >= 0) != (j >= 0))
                {
                    return false;
                }
                i--;
                j--;
            }

            return true;
        }
    }
}
