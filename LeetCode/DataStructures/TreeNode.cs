namespace LeetCode.DataStructures
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static TreeNode GetTreeNode(params int?[] list)
        {
            var t = GetTreeNode(list, 0);

            return t;
        }

        static TreeNode GetTreeNode(int?[] list, int start)
        {
            if (start < list.Length)
            {
                var val = list[start];
                if (val != null && val is int v)
                {
                    return new TreeNode(v, GetTreeNode(list, 2 * start + 1), GetTreeNode(list, 2 * start + 2));
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
