using LeetCode.DataStructures;

namespace LeetCode.Medium
{
    public partial class Solution
    {
        public bool IsValidBST(TreeNode root)
        {
            return IsValidBST(root, null, null);
        }

        bool IsValidBST(TreeNode root, int? lowerBound, int? upperBound)
        { 
            if (root == null)
            {
                return true;
            }
            if (root.val <= lowerBound || root.val >= upperBound)
            {
                return false;
            }
            return IsValidBST(root.left, lowerBound, root.val) && IsValidBST(root.right, root.val, upperBound);
        }
    }
}
