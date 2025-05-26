namespace CsharpExercises;

internal static class LeetCode_BestTimeToBuyAndSellStock2
{
    internal static void Start(int[] inputData)
    {
        var notHold = 0;
        var hold = -inputData[0];
        
        for (var i = 1; i < inputData.Length; i++)
        {
            var prevNotHold = notHold;
            notHold = Math.Max(notHold, hold + inputData[i]);  
            hold = Math.Max(hold, prevNotHold - inputData[i]);
        }
        
        Console.WriteLine(notHold);
    }
}