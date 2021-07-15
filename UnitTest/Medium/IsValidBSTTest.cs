using FluentAssertions;
using LeetCode.DataStructures;
using LeetCode.Medium;
using Xunit;

namespace UnitTest.Medium
{
	public class IsValidBSTTest
	{
		Solution solution = new Solution();

		[Fact]
		public void Test1()
		{
			var n1 = TreeNode.GetTreeNode(5, 4, 6, null, null, 3, 7);
			var n2 = TreeNode.GetTreeNode(2, 2, 2);
			var n3 = TreeNode.GetTreeNode(2, 1, 3);
			var n4 = TreeNode.GetTreeNode(int.MaxValue);

			solution.IsValidBST(n1).Should().BeFalse();
			solution.IsValidBST(n2).Should().BeFalse();
			solution.IsValidBST(n3).Should().BeTrue();
			solution.IsValidBST(n4).Should().BeTrue();

		}
	}
}
