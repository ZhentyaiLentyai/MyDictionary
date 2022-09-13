``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
.NET SDK=6.0.400
  [Host] : .NET 6.0.8 (6.0.822.36306), X64 RyuJIT

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|                   Method |       Mean |    Error |   StdDev | MValue | Rank |
|------------------------- |-----------:|---------:|---------:|-------:|-----:|
|  DictionaryTestSearch100 |   369.9 ns |  5.58 ns |  4.66 ns |  2.000 |    1 |
| DictionaryTestSearch1000 |   375.8 ns |  7.45 ns | 19.89 ns |  2.519 |    1 |
|       BTreeTestSearch100 |   708.8 ns |  5.91 ns |  5.53 ns |  2.000 |    2 |
|      BTreeTestSearch1000 | 1,107.0 ns | 22.11 ns | 33.77 ns |  2.000 |    4 |
|  BinaryTreeTestSearch100 |   908.5 ns | 18.14 ns | 32.72 ns |  2.000 |    3 |
| BinaryTreeTestSearch1000 | 1,187.3 ns |  9.49 ns |  8.88 ns |  2.000 |    5 |
