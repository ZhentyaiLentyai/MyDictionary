using System;
using DictionaryTest;
using DictionaryBTree;
using DictionaryBinaryTree;
using BenchmarkDotNet.Running;

namespace Benchmark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Run DictionaryBenchmark");
            Console.WriteLine("2. Run BTreeBenchmark");
            Console.WriteLine("3. Run BinaryTreeBenchmark");
            Console.WriteLine("4. Run all Benchamrks");
            Console.Write("->");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    BenchmarkRunner.Run<DictionaryBenchmark>();
                    break;
                case 2:
                    BenchmarkRunner.Run<BTreeBenchmark>();
                    break;
                case 3:
                    BenchmarkRunner.Run<BinaryTreeBenchmark>();
                    break;
                case 4:
                    BenchmarkRunner.Run<DictionaryBenchmark>();
                    BenchmarkRunner.Run<BTreeBenchmark>();
                    BenchmarkRunner.Run<BinaryTreeBenchmark>();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
