``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT


```
|                   Method |        Mean |      Error |     StdDev | MValue | Rank |
|------------------------- |------------:|-----------:|-----------:|-------:|-----:|
|       BTreeTestSearch100 |    73.43 μs |   2.335 μs |   6.549 μs |  2.207 |    1 |
|      BTreeTestSearch1000 | 2,988.33 μs | 144.498 μs | 385.695 μs |  3.048 |    3 |
|  BinaryTreeTestSearch100 |   113.55 μs |   2.228 μs |   3.402 μs |  2.000 |    2 |
| BinaryTreeTestSearch1000 | 4,406.33 μs |  87.807 μs | 203.507 μs |  2.000 |    4 |
