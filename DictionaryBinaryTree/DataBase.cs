using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBinaryTree
{
    public class DataBase
    {
        public BinaryTree TreeLoading(int n)
        {
            Random random = new Random();
            int key = random.Next(1, n + 1);
            BinaryTree tree = new BinaryTree(key, null, "!" + key + "!");

            int[] keys = new int[n];
            keys[0] = key;

            for (int counter = 1; counter < n; counter++)
            {
                key = random.Next(1, n + 1);
                if (keys.Contains(key))
                {
                    counter--;
                    continue;
                }

                tree.Add(key, "!" + key + "!");
                keys[counter] = key;
            }
            return tree;
        }
    }
}
