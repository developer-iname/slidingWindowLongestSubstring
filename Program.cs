internal class Program
{
    private static void Main(string[] args)
    {
        Solution firstSolution = new Solution();
        string insertString = "abcabcbb";
        int returnedStringValue = firstSolution.slidingWindowMethodLongestSubstring(insertString);
        Console.WriteLine(returnedStringValue);
    }
}
class Solution
{
    public Solution(){}
    public int slidingWindowMethodLongestSubstring(string s)
    {
        char[] charArrayFromString = s.ToCharArray();
        int maxSubstring = 0, indexOfChar = -1;
        System.Text.StringBuilder solutionStringBuilder = new System.Text.StringBuilder();
        for(int right = 0; right < charArrayFromString.Length; right++)
        {
            indexOfChar = solutionStringBuilder.ToString().IndexOf(charArrayFromString[right]);
            if (indexOfChar != -1)
            {
                solutionStringBuilder.Remove(0, indexOfChar + 1);
            }
            solutionStringBuilder.Append(charArrayFromString[right]);
            Math.Max(maxSubstring, solutionStringBuilder.Length);
        }
        return maxSubstring;
    }   
}