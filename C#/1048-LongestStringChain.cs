namespace LongestStringChain
{


    public class Solution
    {
        public int LongestStrChain(string[] words)
        {
            Array.Sort(words, (x, y) => x.Length.CompareTo(y.Length));
            int max = 0;
            for (int i = 0; i < words.Count(); i++)
            {
                int m = BackTrackingSearch(words, words[i], i, 1);
                if (m > max)
                {
                    max = m;
                }
            }
            return max;
        }


        public int BackTrackingSearch(string[] words, string prevWord, int index, int depth)
        {
            for (int i = index; i < words.Count(); i++)
            {
                if (words[i].Length > prevWord.Length)
                {
                    if (Distance.getDistance(prevWord, words[i]) == 1)
                    {
                        return BackTrackingSearch(words, words[i], i + 1, depth + 1);
                    }
                }
            }

            return 1;
        }
    }



    public static class Distance
    {
        public static int getDistance(string word1, string word2)
        {
            int[,] distance = new int[word1.Length + 1, word2.Length + 1];

            for (int i = 0; i <= word1.Length; distance[i, 0] = i++)
            {
            }
            for (int j = 0; j <= word2.Length; distance[0, j] = j++)
            {
            }

            for (int i = 1; i <= word1.Length; i++)
            {
                for (int j = 1; j <= word2.Length; j++)
                {
                    distance[i, j] = distance[i, j - 1];
                }
            }

            return distance[word1.Length, word2.Length];
        }
    }
}