``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host]     : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT
  DefaultJob : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT


```
|              Method |     Mean |     Error |    StdDev | MValue | Rank |
|-------------------- |---------:|----------:|----------:|-------:|-----:|
|  BTreeTestSearch100 | 2.819 ns | 0.0860 ns | 0.1056 ns |  2.667 |    1 |
|  BTreeTestSearch500 | 3.273 ns | 0.0954 ns | 0.1021 ns |  2.000 |    2 |
| BTreeTestSearch1000 | 2.792 ns | 0.0844 ns | 0.0972 ns |  2.667 |    1 |
