namespace AllMethods
{
    public static class CV
    {
        public static List<string> GetPINs(string observed)
        {
            var result = new List<string>();
            int orders = observed.Length - 1;
            char[] pinVersion = new char[orders + 1];
            List<char>[] charVariantsSets = new List<char>[orders + 1];
            for (int i = 0; i <= orders; i++)
            {
                charVariantsSets[i] = GetNeighbors(observed[i]);
            }
            PushToAnswer(pinVersion, result, charVariantsSets, 0);
            return result;
        }
        static void PushToAnswer(char[] aswer, List<string> res, List<char>[] chars, int n)
        {
            foreach (char c in chars[n])
            {
                aswer[n] = c;
                if (n == aswer.Length - 1)
                {
                    res.Add(new string(aswer));
                }
                else
                {
                    PushToAnswer(aswer, res, chars, n + 1);
                }
            }
        }
        public static List<char> GetNeighbors(char input)
        {
            int i = 0, j = 0;
            char[,] matrix =
            {
                {'1','2','3' },
                {'4','5','6' },
                {'7','8','9' },
                {'-','0','-' }
            };
            var neighbors = new List<char>();
            for (int k = 0; k < matrix.GetLength(0); k++)
            {
                for (int n = 0; n < matrix.GetLength(1); n++)
                {
                    if (k == matrix.GetLength(0) && (n == 0 || n == matrix.GetLength(1) - 1))
                    {
                        continue;
                    }
                    if (matrix[k, n] == input)
                    {
                        i = k;
                        j = n;
                    }
                }
            }
            for (int k = i - 1; k < i + 2; k++)
            {
                if (k >= 0 && k < matrix.GetLength(0))
                {
                    if (Char.IsDigit(matrix[k, j]))
                    {
                        neighbors.Add(matrix[k, j]);
                    }
                }
            }
            if (j - 1 >= 0)
            {
                if (Char.IsDigit(matrix[i, j - 1]))
                {
                    neighbors.Add(matrix[i, j - 1]);
                }

            }
            if (j + 1 < matrix.GetLength(1))
            {
                if (Char.IsDigit(matrix[i, j + 1]))
                {
                    neighbors.Add(matrix[i, j + 1]);
                }
            }
            return neighbors;
        }

        public static List<int> TreeByLevels(Node node)
        {
            List<int> list = new List<int>();
            if (node is null) return list;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                Node n = queue.Dequeue();
                list.Add(n.Value);
                if (n.Left != null)
                {
                    queue.Enqueue(n.Left);
                }
                if (n.Right != null)
                {
                    queue.Enqueue(n.Right);
                }
            }
            return list;
        }
    }
}