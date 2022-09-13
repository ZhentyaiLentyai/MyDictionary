using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using Main;
using DictionaryLib;
using DictionaryBTreeLib;
using DictionaryBinaryTreeLib;

namespace Benchmark
{
    [RankColumn]
    [MValueColumn]
    [InProcess]
    public class AllBenchmarks
    {
        private int[] keys100 = DataBase.DataBaseLoading(100);
        private int[] keys1000 = DataBase.DataBaseLoading(1000);
        private int[] keys10000 = DataBase.DataBaseLoading(10000);

        private IEnumerable<int> keysToSearch100;
        private IEnumerable<int> keysToSearch1000;
        private IEnumerable<int> keysToSearch10000;

        private Dictionary<int, string> Dictionary100;
        private Dictionary<int, string> Dictionary1000;
        private Dictionary<int, string> Dictionary10000;
        
        private BTree<int, string> BTree100;
        private BTree<int, string> BTree1000;
        private BTree<int, string> BTree10000;
        
        private BinaryTree<int, string> binaryTree100;
        private BinaryTree<int, string> binaryTree1000;
        private BinaryTree<int, string> binaryTree10000;

        [GlobalSetup]
        public void Initialize()
        {
            Dictionary100 = DataBase.DictionaryLoading(keys100);
            Dictionary1000 = DataBase.DictionaryLoading(keys1000);
            Dictionary10000 = DataBase.DictionaryLoading(keys10000);

            BTree100 = DataBase.BTreeLoading(keys100);
            BTree1000 = DataBase.BTreeLoading(keys1000);
            BTree10000 = DataBase.BTreeLoading(keys10000);

            binaryTree100 = DataBase.BinaryTreeLoading(keys100);
            binaryTree1000 = DataBase.BinaryTreeLoading(keys1000);
            binaryTree10000 = DataBase.BinaryTreeLoading(keys10000);

            keysToSearch100 = GetRundomElements(keys100, 10);
            keysToSearch1000 = GetRundomElements(keys1000, 10);
            keysToSearch10000 = GetRundomElements(keys10000, 10);
        }

        private IEnumerable<int> GetRundomElements(IList<int> originalCollection, int elementsCount)
        {
            Random random = new Random();
            while(elementsCount-- > 0)
            {
                int index = random.Next(0, originalCollection.Count-1);
                yield return originalCollection[index];
            }
        }

        //Dictionary--------------------------------------------------------------------------------------------------------
        //100 key
        [Benchmark]
        public void DictionaryTestSearch100()
        {
            foreach(var keyToSearch in keysToSearch100)
            {
                Dictionary100.ContainsKey(keyToSearch);
            }
        }

        //1000 keys
        [Benchmark]
        public void DictionaryTestSearch1000()
        {
            foreach (var keyToSearch in keysToSearch1000)
            {
                Dictionary1000.ContainsKey(keyToSearch);
            }
        }

        //10000 keys
        //[Benchmark]
        public void DictionaryTestSearch10000()
        {
            foreach(var keyToSearch in keysToSearch10000)
            {
                Dictionary10000.ContainsKey(keyToSearch);
            }
        }

        //BTree--------------------------------------------------------------------------------------------------------
        //100 keys
        [Benchmark]
        public void BTreeTestSearch100()
        {
            foreach (var keyToSearch in keysToSearch100)
            {
                BTree100.Search(keyToSearch);
            }
        }

        //1000 keys
        [Benchmark]
        public void BTreeTestSearch1000()
        {
            foreach (var keyToSearch in keysToSearch1000)
            {
                BTree1000.Search(keyToSearch);
            }
        }

        //10000 keys
        //[Benchmark]
        public void BTreeTestSearch10000()
        {
            foreach (var keyToSearch in keysToSearch10000)
            {
                BTree10000.Search(keyToSearch);
            }
        }

        //BinaryTree--------------------------------------------------------------------------------------------------------
        //100 keys
        [Benchmark]
        public void BinaryTreeTestSearch100()
        {
            foreach (var keyToSearch in keysToSearch100)
            {
                binaryTree100.Search(keyToSearch);
            }
        }

        //1000 keys
        [Benchmark]
        public void BinaryTreeTestSearch1000()
        {
            foreach (var keyToSearch in keysToSearch1000)
            {
                binaryTree1000.Search(keyToSearch);
            }
        }

        //10000 keys
        //[Benchmark]
        public void BinaryTreeTestSearch10000()
        {
            foreach (var keyToSearch in keysToSearch10000)
            {
                binaryTree10000.Search(keyToSearch);
            }
        }
    }
}
