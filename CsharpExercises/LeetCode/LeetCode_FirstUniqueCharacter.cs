namespace CsharpExercises.LeetCode;

public class LeetCode_FirstUniqueCharacter
{
    internal static int Find(string s)
    {
        if (s.Length == 1)
            return 0;

        var except = new HashSet<char>();

        for (var i = 0; i < s.Length; i++)
        {
            var c = s[i];
            
            if (except.Contains(c)) 
                continue;

            if (s.IndexOf(c, i + 1) == -1)
                return i;
            
            except.Add(c);
        }

        return -1;
    }
}