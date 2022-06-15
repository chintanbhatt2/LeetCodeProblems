namespace WordSearchII
{
    public class Solution
    {
        private TreeNode root = new TreeNode(' ');
        private List<(int, int)> Visited = new List<(int X, int Y)>();

        private HashSet<string> AllWords = new HashSet<string>();
        public IList<string> FindWords(char[][] board, string[] words)
        // public IList<string> FindWords(char[,] board, string[] words)
        {
            root.PopulateTree(words);
            // Go through all sqaures of the grid

            for (int i = 0; i < board.Count(); i++)
            {
                for (int j = 0; j < board[i].Count(); j++)
                {
                    // If the letter in the square matches the first letter in any of the words,
                    if (root.validateWord(board[i][j].ToString()) >= TreeNode.validation.VALID)
                    {
                        //    drill down into the surround squares via backtracking
                        Visited.Clear();
                        BacktrackWordFinder(board, i, j, "");
                    }
                }
            }
            return AllWords.ToList();
        }



        //    If you can find the complete word, add the word to the list and return to the top
        //    otherwise, come back and continue to the next square

        private void BacktrackWordFinder(char[][] board, int x, int y, string currentWord)
        {

            if (Visited.Contains((x, y))) return;

            string newWord = currentWord;
            newWord += board[x][y];

            TreeNode.validation valid = root.validateWord(newWord);
            if (valid == TreeNode.validation.COMPLETE)
            {
                AllWords.Add(newWord);
                root.removeWord(newWord);
            }

            if (valid >= TreeNode.validation.VALID)
            {
                Visited.Add((x, y));
                BacktrackWordFinder(board, Math.Min(x + 1, board.Count() - 1), y, newWord);
                BacktrackWordFinder(board, Math.Max(x - 1, 0), y, newWord);
                BacktrackWordFinder(board, x, Math.Min(y + 1, board[x].Count() - 1), newWord);
                BacktrackWordFinder(board, x, Math.Max(y - 1, 0), newWord);
            }

            Visited.Remove((x, y));
            return;

        }
    }



    public class TreeNode
    {
        public List<TreeNode> children;
        public char Letter;
        public bool isTerminal = false;
        public TreeNode(char character)
        {
            children = new List<TreeNode>();
            Letter = character;
        }

        public void PopulateTree(string[] words)
        {
            for (int i = 0; i < words.Count(); i++)
            {
                AddWordToTree(words[i]);
            }
        }

        private void AddWordToTree(string word)
        {
            if (word == "")
            {
                isTerminal = true;
                return;
            }
            string newWord = word.Substring(1);

            foreach (var node in children)
            {
                if (node.Letter == word[0])
                {
                    node.AddWordToTree(newWord);
                    return;
                }
            }

            children.Add(new TreeNode(word[0]));
            children.Last().AddWordToTree(newWord);

        }

        public enum validation
        {
            INVALID = 0,
            VALID = 1,
            COMPLETE = 2
        }
        public validation validateWord(string word)
        {
            if (word == "" && isTerminal)
            {
                return validation.COMPLETE;
            };
            if (word == "") return validation.VALID;
            foreach (var node in children)
            {
                if (node.Letter == word[0])
                {
                    return node.validateWord(word.Substring(1));
                }
            }
            return validation.INVALID;
        }

        private bool Matcher(char letter)
        {
            return Letter == letter ? true : false;
        }
        public bool removeWord(string word)
        {

            if (word == "" && isTerminal && children.Count() == 0)
            {
                return true;
            }
            if (word == "" && isTerminal && children.Count() >= 1)
            {
                isTerminal = false;
                return false;
            }

            int index = 0;

            for (int i = 0; i < children.Count(); i++)
            {
                if (word[0] == children[i].Letter)
                {
                    index = i;
                    break;
                }
            }

            if (children[index].removeWord(word.Substring(1)))
            {
                children.RemoveAt(index);
                if (children.Count() == 0 && !isTerminal)
                {
                    return true;
                }
            }

            return false;
        }
    }


}