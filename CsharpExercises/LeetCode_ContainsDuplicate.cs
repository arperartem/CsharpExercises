namespace CsharpExercises;

public class LeetCode_ContainsDuplicate
{
    internal static void Start(int[] nums)
    {
        var result = false;
        var hashSet = new HashSet<int>();
        
        for (var i = 0; i < nums.Length; i++)
            if (!hashSet.Add(nums[i]))
                result = true;
        Console.WriteLine(result);
    }
}