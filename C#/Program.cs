using LongestStringChain;

public class Program
{
    public static void Main()
    {
        Solution s = new Solution();


        string[] words1 = new string[] { "a", "b", "ba", "bca", "bda", "bdca" };
        string[] words2 = new string[] { "xbc", "pcxbcf", "xb", "cxbc", "pcxbc" };
        string[] words3 = new string[] { "abcd", "dbqca" };

        if (4 == s.LongestStrChain(words1))
        {
            Console.WriteLine("Test 1: Passed");
        }
        else
        {
            Console.WriteLine("Test 1: Failed");
        }
        if (5 == s.LongestStrChain(words2))
        {
            Console.WriteLine("Test 2: Passed");
        }
        else
        {
            Console.WriteLine("Test 2: Failed");
        }
        if (1 == s.LongestStrChain(words3))
        {
            Console.WriteLine("Test 3: Passed");
        }
        else
        {
            Console.WriteLine("Test 3: Failed");
        }
    }
}