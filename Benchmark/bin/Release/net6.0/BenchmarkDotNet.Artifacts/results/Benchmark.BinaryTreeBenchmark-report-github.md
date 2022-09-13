``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|                    Method |     Mean |    Error |   StdDev | MValue | Rank |
|-------------------------- |---------:|---------:|---------:|-------:|-----:|
|   BinaryTreeTestSearch100 | 17.08 ns | 0.333 ns | 0.312 ns |  2.000 |    1 |
|  BinaryTreeTestSearch1000 | 19.64 ns | 0.183 ns | 0.172 ns |  2.000 |    2 |
| BinaryTreeTestSearch10000 | 41.13 ns | 0.444 ns | 0.416 ns |  2.000 |    3 |
