namespace CsharpExercises;

public class LeetCode_ContainsDuplicate
{
    internal static void Start()
    {
        var nums = new[] { 1,2,3,4 };

        var result = false;
        var hashSet = new HashSet<int>();
        
        for (var i = 0; i < nums.Length; i++)
            if (!hashSet.Add(nums[i]))
                result = true;
        Console.WriteLine(result);
    }
}