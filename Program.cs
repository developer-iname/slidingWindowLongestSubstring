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
        int right = 0, maxSubstring = 0;
        bool repeatedCharacter = false;
        System.Text.StringBuilder solutionStringBuilder = new System.Text.StringBuilder();
        for(right = 0; right < charArrayFromString.Length; right++)
        {
            repeatedCharacter = solutionStringBuilder.ToString().Contains(charArrayFromString[right]);
            if (repeatedCharacter)
            {
                solutionStringBuilder.Remove(0, solutionStringBuilder.ToString().IndexOf(charArrayFromString[right]) + 1);
            }
            solutionStringBuilder.Append(charArrayFromString[right]);
            maxSubstring = (maxSubstring < solutionStringBuilder.Length) ? maxSubstring = solutionStringBuilder.Length : maxSubstring;
        }
        return maxSubstring;
    }   
}

