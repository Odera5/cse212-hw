using System.Collections;

public static class Recursion
{
    /// <summary>
    /// #############
    /// # Problem 1 #
    /// #############
    /// Using recursion, find the sum of 1^2 + 2^2 + 3^2 + ... + n^2
    /// and return it.  Remember to both express the solution 
    /// in terms of recursive call on a smaller problem and 
    /// to identify a base case (terminating case).  If the value of
    /// n <= 0, just return 0.   A loop should not be used.
    /// </summary>
    public static int SumSquaresRecursive(int n)
    {
        // Base case
        if (n <= 0)
            return 0;

        // Recursive case
        return (n * n) + SumSquaresRecursive(n - 1);
    }

    /// <summary>
    /// #############
    /// # Problem 2 #
    /// #############
    /// Using recursion, insert permutations of length
    /// 'size' from a list of 'letters' into the results list.
    /// </summary>
    public static void PermutationsChoose(List<string> results, string letters, int size, string word = "")
    {
        // Base case
        if (word.Length == size)
        {
            results.Add(word);
            return;
        }

        // Recursive case
        for (int i = 0; i < letters.Length; i++)
        {
            char letter = letters[i];

            // Skip letters already used
            if (!word.Contains(letter))
            {
                PermutationsChoose(results, letters, size, word + letter);
            }
        }
    }

    /// <summary>
    /// #############
    /// # Problem 3 #
    /// #############
    /// Count ways to climb stairs using memoization.
    /// </summary>
    public static decimal CountWaysToClimb(int s, Dictionary<int, decimal>? remember = null)
    {
        // Base Cases
        if (s == 0)
            return 0;
        if (s == 1)
            return 1;
        if (s == 2)
            return 2;
        if (s == 3)
            return 4;

        // Initialize dictionary if needed
        if (remember == null)
        {
            remember = new Dictionary<int, decimal>();
        }

        // Return remembered value if already solved
        if (remember.ContainsKey(s))
        {
            return remember[s];
        }

        // Recursive solution
        decimal ways =
            CountWaysToClimb(s - 1, remember) +
            CountWaysToClimb(s - 2, remember) +
            CountWaysToClimb(s - 3, remember);

        // Store answer
        remember[s] = ways;

        return ways;
    }

    /// <summary>
    /// #############
    /// # Problem 4 #
    /// #############
    /// Generate all binary strings from wildcard pattern.
    /// </summary>
    public static void WildcardBinary(string pattern, List<string> results)
    {
        int wildcardIndex = pattern.IndexOf('*');

        // Base case: no wildcard left
        if (wildcardIndex == -1)
        {
            results.Add(pattern);
            return;
        }

        // Replace wildcard with 0
        string withZero =
            pattern[..wildcardIndex] + "0" + pattern[(wildcardIndex + 1)..];

        // Replace wildcard with 1
        string withOne =
            pattern[..wildcardIndex] + "1" + pattern[(wildcardIndex + 1)..];

        // Recursive calls
        WildcardBinary(withZero, results);
        WildcardBinary(withOne, results);
    }

    /// <summary>
    /// Use recursion to insert all paths that start at (0,0) and end at the
    /// 'end' square into the results list.
    /// </summary>
    public static void SolveMaze(List<string> results, Maze maze, int x = 0, int y = 0, List<ValueTuple<int, int>>? currPath = null)
    {
        // Initialize path if first call
        if (currPath == null)
        {
            currPath = new List<ValueTuple<int, int>>();
        }

        // Check if move is valid
        if (!maze.IsValidMove(currPath, x, y))
        {
            return;
        }

        // Add current position to path
        currPath.Add((x, y));

        // Check if reached end
        if (maze.IsEnd(x, y))
        {
            results.Add(currPath.AsString());
            return;
        }

        // Explore all four directions
        SolveMaze(results, maze, x + 1, y, new List<ValueTuple<int, int>>(currPath)); // Right
        SolveMaze(results, maze, x - 1, y, new List<ValueTuple<int, int>>(currPath)); // Left
        SolveMaze(results, maze, x, y + 1, new List<ValueTuple<int, int>>(currPath)); // Down
        SolveMaze(results, maze, x, y - 1, new List<ValueTuple<int, int>>(currPath)); // Up
    }
}