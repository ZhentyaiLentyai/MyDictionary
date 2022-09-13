``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1889 (21H1/May2021Update)
AMD Ryzen 7 3700U with Radeon Vega Mobile Gfx, 1 CPU, 8 logical and 4 physical cores
  [Host]     : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT
  DefaultJob : .NET Framework 4.8 (4.8.4515.0), X86 LegacyJIT


```
|                    Method | Mean | Error | MValue | Rank |
|-------------------------- |-----:|------:|-------:|-----:|
|   DictionaryTestSearch100 |   NA |    NA |     NA |    ? |
|  DictionaryTestSearch1000 |   NA |    NA |     NA |    ? |
| DictionaryTestSearch10000 |   NA |    NA |     NA |    ? |

Benchmarks with issues:
  DictionaryBenchmark.DictionaryTestSearch100: DefaultJob
  DictionaryBenchmark.DictionaryTestSearch1000: DefaultJob
  DictionaryBenchmark.DictionaryTestSearch10000: DefaultJob
