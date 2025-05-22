namespace CsharpExercises;

public class LeetCode_RotateArray
{
    /*[1,2,3,4,5,6,7]
      [5,6,7,1,2,3,4]

    [-1,-100,  3, 99, 50]
    [ 99  50  -1 -100  3]

    [-1,-100,3,99]
    [ 3, 99,-1,-100]*/
    internal static void Start()
    {
        var nums = new[] { 1,2,3,4,5,6,7 };
        var k = 3;
        
        if(nums.Length <= 1)
            return;
        
        var buffer = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            buffer[i] = nums[i];
            nums[i] = 0;
        }
        
        var offset = k % nums.Length;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i + offset >= nums.Length)
                nums[offset - (nums.Length - i)] = buffer[i];
            else
                nums[i + offset] = buffer[i];
        }
        
        for (var i = 0; i < nums.Length; i++)
            Console.Write(nums[i] + " ");
    }
}