```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3810/23H2/2023Update/SunValley3)
AMD Ryzen 7 5800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 8.0.302
  [Host]     : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2
  Job-LEFOSM : .NET 8.0.6 (8.0.624.26715), X64 RyuJIT AVX2

RunStrategy=Throughput  

```
| Method                     | Categories | Mean       | Error     | StdDev    | Allocated |
|--------------------------- |----------- |-----------:|----------:|----------:|----------:|
| MapperlyAggressiveInlining | Class      | 11.8346 ns | 0.1994 ns | 0.1865 ns |     104 B |
| Mapperly                   | Class      | 12.3052 ns | 0.2888 ns | 0.3326 ns |     104 B |
| ManualMapping              | Class      | 13.1910 ns | 0.3032 ns | 0.2836 ns |     104 B |
|                            |            |            |           |           |           |
| MapperlyAggressiveInlining | Struct     |  0.4198 ns | 0.0088 ns | 0.0082 ns |         - |
| ManualMapping              | Struct     |  5.7322 ns | 0.0166 ns | 0.0156 ns |         - |
| Mapperly                   | Struct     |  7.1755 ns | 0.0426 ns | 0.0398 ns |         - |
