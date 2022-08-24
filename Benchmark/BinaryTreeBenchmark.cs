using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using DictionaryBinaryTree;

namespace Benchmark
{
    [RankColumn]
    [MValueColumn]
    public class BinaryTreeBenchmark
    {
        private const int key = 1;
        private readonly DataBase data = new DataBase();
        private BinaryTree tree;

        //100 keys
        [Benchmark]
        public void TestSearch100()
        {
            tree = data.TreeLoading(100);
            tree.SearchKey(tree, key);
        }

        //1000 keys
        [Benchmark]
        public void TestSearch1000()
        {
            tree = data.TreeLoading(1000);
            tree.SearchKey(tree, key);
        }

        //10000 keys
        [Benchmark]
        public void TestSearch10000()
        {
            tree = data.TreeLoading(10000);
            tree.SearchKey(tree, key);
        }
    }
}
