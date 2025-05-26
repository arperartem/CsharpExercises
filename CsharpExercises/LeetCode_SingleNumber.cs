namespace CsharpExercises;

public class LeetCode_SingleNumber
{
    internal static void Start(int[] nums)
    {
        if(nums.Length == 1)
        {
            Console.WriteLine(nums[0]);
            return;
        }

        var hashSet = new HashSet<int>();
        
        for (var i = 0; i < nums.Length; i++)
            if (hashSet.Add(nums[i]) == false)
                hashSet.Remove(nums[i]);
        
        //right variant - XOR
        
        Console.WriteLine(hashSet.First());
    }
}