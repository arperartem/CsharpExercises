namespace CsharpExercises.LeetCode;

internal static class LeetCode_TwoSum
{
    internal static int[] TwoSum(int[] nums, int target)
    {
        var result = new int[2];
        for (var i = 0; i + 1 < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                }
            }
        }

        return result;
    }
    
    internal static int[] TwoSumV2(int[] nums, int target)
    {
        var result = new int[2];
        var container = new Dictionary<int, int> { { nums[0], 0 } };

        for (var i = 1; i < nums.Length; i++)
        {
            if (container.ContainsKey(target - nums[i]))
            {
                result[0] = container[target - nums[i]];
                result[1] = i;
                break;
            }

            container[nums[i]] = i;
        }

        return result;
    }
}