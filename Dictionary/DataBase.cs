using System;
using System.Linq;
using System.Collections.Generic;
using DictionaryLib;
using DictionaryBTreeLib;
using DictionaryBinaryTreeLib;

namespace Main
{
    public class DataBase
    {
        public static int[] DataBaseLoading(int n)
        {
            int[] keys = new int[n];

            Random random = new Random();

            for (int counter = 0; counter < n; counter++)
            {
                int key = random.Next(1, n + 1);
                if (keys.Contains(key))
                {
                    counter--;
                    continue;
                }
                keys[counter] = key;
            }
            return keys;
        }
        public static Dictionary<int, string> DictionaryLoading(int[] keys)
        {
            Dictionary<int, string> numbers = new Dictionary<int, string>();

            for (int counter = 0; counter < keys.Length; counter++)
            {
                numbers.Add(keys[counter], "!" + keys[counter] + "!");
            }
            return numbers;
        }
        public static BTree<int,string> BTreeLoading(int[] keys)
        {
            BTree<int, string> tree = new BTree<int, string>(2);

            for (int counter = 0; counter < keys.Length; counter++)
            {
                tree.Add(keys[counter], "!" + keys[counter] + "!");
            }
            return tree;
        }
        public static BinaryTree<int, string> BinaryTreeLoading(int[] keys)
        {
            BinaryTree<int, string> tree = new BinaryTree<int, string>(keys[0], null, "!" + keys[0] + "!");

            for (int counter = 1; counter < keys.Length; counter++)
            {
                tree.Add(keys[counter], "!" + keys[counter] + "!");
            }
            return tree;
        }
        public static int[] SearchKeys(int n, int[] keys)
        {
            int[] SearchKeys = new int[n];

            Random random = new Random();
            for (int counter = 0; counter < n; counter++)
            {
                int index = random.Next(1, keys.Length + 1);

                if (SearchKeys.Contains(keys[index]))
                {
                    counter--;
                    continue;
                }
                SearchKeys[counter] = keys[index];
            }
            return SearchKeys;
        }
    }
}
