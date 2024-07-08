using Mapperly_Benchmark.Benchmark1.Models;
using Riok.Mapperly.Abstractions;

namespace Mapperly_Benchmark.Benchmark1;

[Mapper]
public static partial class MapperlyMapperAggressiveInlining
{
    public static partial MyClass MapToClass(MyClassDto myClassDto);

    public static partial MyStruct MapToStruct(MyStructDto myStructDto);
}