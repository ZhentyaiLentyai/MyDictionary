using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using DictionaryTest;

namespace Benchmark
{
    [RankColumn]
    [MValueColumn]
    public class DictionaryBenchmark
    {
        private const int key = 1;
        Dictionary<int, string> numbers = new Dictionary<int, string>();

        //1000 key
        [Benchmark]
        public void DictionaryTestSearch100()
        {
            numbers = ProgramDictionary.DataDictionary(100);
            ProgramDictionary.SearchKey(numbers, key);
        }

        //1000 keys
        [Benchmark]
        public void DictionaryTestSearch1000()
        {
            numbers = ProgramDictionary.DataDictionary(1000);
            ProgramDictionary.SearchKey(numbers, key);
        }

        //10000 keys
        [Benchmark]
        public void DictionaryTestSearch10000()
        {
            numbers = ProgramDictionary.DataDictionary(10000);
            ProgramDictionary.SearchKey(numbers, key);
        }
    }
}
