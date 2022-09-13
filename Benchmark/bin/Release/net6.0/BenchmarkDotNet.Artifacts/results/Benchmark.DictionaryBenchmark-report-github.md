``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|                    Method |     Mean |     Error |    StdDev | MValue | Rank |
|-------------------------- |---------:|----------:|----------:|-------:|-----:|
|   DictionaryTestSearch100 | 8.364 ns | 0.1655 ns | 0.1382 ns |  2.000 |    1 |
|  DictionaryTestSearch1000 | 9.023 ns | 0.1967 ns | 0.1840 ns |  2.000 |    2 |
| DictionaryTestSearch10000 | 8.461 ns | 0.1801 ns | 0.1597 ns |  2.000 |    1 |
