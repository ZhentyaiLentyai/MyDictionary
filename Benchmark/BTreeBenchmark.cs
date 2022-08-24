using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Configs;
using DictionaryBTree;

namespace Benchmark
{
    [RankColumn]
    [MValueColumn]
    public class BTreeBenchmark
    {
        private const int key = 1;
        private readonly BTreeNode tree = new BTreeNode(2, true);
        private readonly DataBase data = new DataBase();

        //100 keys
        [Benchmark]
        public void BTreeTestSearch100()
        {
            data.LoadDataBase(100);
            tree.SearchKey(key);
        }

        //1000 keys
        [Benchmark]
        public void BTreeTestSearch1000()
        {
            data.LoadDataBase(1000);
            tree.SearchKey(key);
        }

        //10000 keys
        [Benchmark]
        public void BTreeTestSearch10000()
        {
            data.LoadDataBase(10000);
            tree.SearchKey(key);
        }
    }
}
