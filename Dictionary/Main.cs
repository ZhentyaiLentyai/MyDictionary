using System;
using System.Collections.Generic;
using DictionaryLib;
using DictionaryBTreeLib;
using DictionaryBinaryTreeLib;

namespace Main
{
    internal class MainProgram
    {
        static void Main(string[] args)
        {
            int n = 100;
            int[] keys = DataBase.DataBaseLoading(n);

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Dictionary<int, string> numbers = DataBase.DictionaryLoading(keys);
                    Dictionary.Search(numbers);
                    break;
                case 2:
                    BTree<int,string> BTree = DataBase.BTreeLoading(keys);
                    BTree.Search(10);
                    break;
                case 3:
                    BinaryTree<int, string> BinaryTree = DataBase.BinaryTreeLoading(keys);
                    BinaryTree.Search(10);
                    break;

                default:
                    break;
            }
        }
    }
}
