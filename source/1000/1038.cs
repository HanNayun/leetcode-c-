using source.structs;

namespace source._1000._1038;

public class Solution
{
    public TreeNode BstToGst(TreeNode root)
    {
        var sum = 0;
        RightRootLeft(root, ref sum);
        return root;
    }

    private void RightRootLeft(TreeNode root, ref int sum)
    {
        if (root == null)
            return;

        RightRootLeft(root.right, ref sum);
        sum += root.val;
        root.val = sum;
        RightRootLeft(root.left, ref sum);
    }
}