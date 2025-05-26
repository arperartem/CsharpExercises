namespace CsharpExercises;

public class LeetCode_ReverseString
{
    internal static void Start(string[] s)
    {
        if(s.Length == 1)
            return;

        for (int i = 0, j = s.Length - 1; i < s.Length; i++, j--)
        {
            if(i == j || i > j)
                break;
            
            (s[j], s[i]) = (s[i], s[j]);
        }
        
        for (var i = 0; i < s.Length; i++)
            Console.Write(s[i] + " ");
    }
}