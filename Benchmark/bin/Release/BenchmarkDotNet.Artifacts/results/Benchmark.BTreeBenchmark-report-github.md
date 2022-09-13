``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT


```
|               Method |          Mean |        Error |        StdDev | MValue | Rank |
|--------------------- |--------------:|-------------:|--------------:|-------:|-----:|
|   BTreeTestSearch100 |      76.76 μs |     2.683 μs |      7.826 μs |  2.500 |    1 |
|  BTreeTestSearch1000 |   2,859.68 μs |    56.967 μs |    152.057 μs |  2.000 |    2 |
| BTreeTestSearch10000 | 287,532.36 μs | 9,375.216 μs | 27,347.946 μs |  3.739 |    3 |
