namespace CsharpExercises.LeetCode;

internal static class LeetCodeRemoveDuplicatesFromSortedArray
{
    internal static void Start(int[] inputData)
    {
        var emptyIndex = 0;
        for (var i = 1; i < inputData.Length; i++)
        {
            if (inputData[i] == inputData[i - 1])
                continue;
            
            inputData[emptyIndex + 1] = inputData[i];
            emptyIndex++;
        }
        
        Console.WriteLine(emptyIndex + 1);
    }
    
}