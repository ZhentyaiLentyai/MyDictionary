using System;
using DictionaryLib;
using DictionaryBTreeLib;
using DictionaryBinaryTreeLib;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<AllBenchmarks>();
            Console.ReadKey();
        }
    }
}
