namespace CsharpExercises;

public class FindMatch
{
    private const int MinLenInRow = 3;
    
    internal readonly struct MatchData
    {
        internal int Value { get; }
        internal List<(int i, int j)> Matches { get; }

        internal MatchData(int value, List<(int i, int j)> matches)
        {
            Value = value;
            Matches = matches;
        }
    }

    internal Dictionary<int, List<MatchData>> Find()
    {
        var inputData = new[,]
        {
            { 0, 1, 0, 1 },
            { 1, 1, 0, 1 },
            { 1, 1, 0, 1 },
            { 1, 1, 1, 0 }
        };

        var result = new Dictionary<int, List<MatchData>>();

        var rows = inputData.GetLength(0);
        var cols = inputData.GetLength(1);
        
        var horizontalMask = new bool[rows, cols];

        var horizontalMatches = Find(rows, cols, (o, i) => inputData[o, i], MinLenInRow);

        for (var i = 0; i < horizontalMatches.Count; i++)
        {
            var value = inputData[horizontalMatches[i][0].i, horizontalMatches[i][0].j];
            
            var copy = new List<(int i, int j)>(horizontalMatches[i].Count);
            for (var j = 0; j < horizontalMatches[i].Count; j++)
            {
                var cell = horizontalMatches[i][j];
                copy.Add(cell);
                horizontalMask[cell.i, cell.j] = true;
            }

            if (result.TryGetValue(value, out var list) == false)
                result[value] = list = new List<MatchData>();
            
            list.Add(new MatchData(value, copy));
        }

        var verticalMatches = Find(cols, rows, (o, i) => inputData[i, o], MinLenInRow);
        
        var filtered = new List<(int i, int j)>(MinLenInRow);
        
        for (var i = 0; i < verticalMatches.Count; i++)
        {
            filtered.Clear();
            for (var k = 0; k < verticalMatches[i].Count; k++)
            {
                var cell = verticalMatches[i][k];
                if (horizontalMask[cell.j, cell.i] == false)
                    filtered.Add((cell.j,  cell.i));
            }

            if (filtered.Count < MinLenInRow)
                continue;

            var value = inputData[filtered[0].i, filtered[0].j];
            
            var copy = new List<(int i, int j)>(filtered.Count);
            
            for (var j = 0; j < filtered.Count; j++)
                copy.Add(filtered[j]);
            
            if (result.TryGetValue(value, out var list) == false)
                result[value] = list = new List<MatchData>();
            
            list.Add(new MatchData(value, copy));
        }

        return result;
    }

    private List<List<(int i, int j)>> Find<T>(int outerSize, int innerSize,
        Func<int, int, T> getCell, int minLen) where T : IEquatable<T>
    {
        var result = new List<List<(int i, int j)>>();
        
        for (var o = 0; o < outerSize; o++)
        {
            var startJ = 0;
            for (var i = 1; i <= innerSize; i++)
            {
                bool continues = i < innerSize
                                 && getCell(o, i).Equals(getCell(o, i - 1));
                if (continues)
                    continue;

                var diff = i - startJ;

                if (diff >= minLen)
                {
                    var list = new List<(int i, int j)>();
                    for (var k = startJ; k < i; k++)
                        list.Add((o, k));
                    
                    result.Add(list);
                }
                startJ = i;
            }
        }
        return result;
    }
}