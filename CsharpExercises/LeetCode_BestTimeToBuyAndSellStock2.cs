namespace CsharpExercises;

internal static class LeetCode_BestTimeToBuyAndSellStock2
{
    internal static void Start()
    {
        var inputData = new[] { 1,2,3,4,5 };

        int notHold = 0;
        int hold = -inputData[0];
        
        for (int i = 1; i < inputData.Length; i++)
        {
            int prevNotHold = notHold;
            notHold = Math.Max(notHold, hold + inputData[i]);   // решили продать сегодня
            hold = Math.Max(hold, prevNotHold - inputData[i]);  // решили купить сегодня
        }
        
        Console.WriteLine(notHold);
    }
}