namespace CsharpExercises;

internal static class LeetCodeRemoveDuplicatesFromSortedArray
{
    internal static void Start(int[] inputData)
    {
        var emptyIndex = 0;
        for (var i = 0; i < inputData.Length; i++)
        {
            if(i == 0)
                continue;

            if (inputData[i] == inputData[i - 1])
                continue;
            
            inputData[emptyIndex + 1] = inputData[i];
            emptyIndex++;
        }
        
        Console.WriteLine(emptyIndex + 1);
    }
    
}