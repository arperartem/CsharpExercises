namespace CsharpExercises.LeetCode;

public class LeetCode_ReverseInteger
{
    internal static int Reverse(int x)
    {
        if (x == int.MinValue) 
            return 0;
        var sign = x < 0 ? -1 : 1;
        var y = Math.Abs(x);
        var rev = 0;

        while (y > 0)
        {
            var digit = y % 10;
            y /= 10;

            if (rev > (int.MaxValue - digit) / 10)
                return 0;
            
            rev = rev * 10 + digit;
        }

        return rev * sign;
    }
}