namespace CsharpExercises.LeetCode;

internal static class LeetCode_MaximumDepthOfBinaryTree
{
    internal class TreeNode
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
    }

    internal static int MaxDepthWithQueue()
    {
        var node7 = new TreeNode(7);
        var node15 = new TreeNode(15);
        var node20 = new TreeNode(20, node7, node15);
        var node9 = new TreeNode(9);
        var node3 = new TreeNode(3, node9, node20);
        
        var queue = new Queue<TreeNode>();
        queue.Enqueue(node3);
        var depth = 0;

        while (queue.Count > 0)
        {
            depth++;
            var levelSize = queue.Count;
            for (int i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                if(node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }

        return depth;
    }

    internal static int MaxDepthWithStack()
    {
        var node7 = new TreeNode(7);
        var node15 = new TreeNode(15);
        var node20 = new TreeNode(20, node7, node15);
        var node9 = new TreeNode(9);
        var node3 = new TreeNode(3, node9, node20);
        
        var stack = new Stack<(TreeNode node, int depth)>();
        stack.Push((node3, 1));
        
        var maxDepth = 0;

        while (stack.Count > 0)
        {
            var (node, depth) = stack.Pop();
            
            if(depth > maxDepth)
                maxDepth = depth;
            
            if(node.left != null)
                stack.Push((node.left, depth + 1));
            
            if(node.right != null)
                stack.Push((node.right, depth + 1));
        }
        
        return maxDepth;
    }
}