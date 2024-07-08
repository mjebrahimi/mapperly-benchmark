using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using DeepEqual.Syntax;
using Mapperly_Benchmark.Benchmark1.Models;

namespace Mapperly_Benchmark.Benchmark1;

#if RELEASE
[SimpleJob(BenchmarkDotNet.Engines.RunStrategy.Throughput)]
//[ShortRunJob]
#endif
[CategoriesColumn]
[MemoryDiagnoser(displayGenColumns: false)]
[Orderer(SummaryOrderPolicy.FastestToSlowest, MethodOrderPolicy.Declared)]
[GroupBenchmarksBy(BenchmarkDotNet.Configs.BenchmarkLogicalGroupRule.ByCategory)]
public class Benchmark1
{
    public static readonly MyClassDto _myClassDto = new MyClassDto
    {
        Int = 100,
        String = "String",
        Boolean = true,
        Long = 100,
        Double = 100.0,
        DateTime = DateTime.Now,
        Enum = MyEnum.Enum1,
        SubClass = new MySubClassDto
        {
            Int = 100,
            String = "String"
        }
    };

    public static readonly MyStructDto _myStructDto = new MyStructDto
    {
        Int = 100,
        String = "String",
        Boolean = true,
        Long = 100,
        Double = 100.0,
        DateTime = DateTime.Now,
        Enum = MyEnum.Enum1,
        SubStruct = new MySubStructDto
        {
            Int = 100,
            String = "String"
        }
    };

    [GlobalSetup]
    public void Setup()
    {
        //Make sure all mappers are working correctly
        ManualMapping_Class().ShouldDeepEqual(_myClassDto);
        Mapperly_Class().ShouldDeepEqual(_myClassDto);
        MapperlyAggressiveInlining_Class().ShouldDeepEqual(_myClassDto);

        ManualMapping_Struct().ShouldDeepEqual(_myStructDto);
        Mapperly_Struct().ShouldDeepEqual(_myStructDto);
        MapperlyAggressiveInlining_Struct().ShouldDeepEqual(_myStructDto);
    }

    #region Class

    [Benchmark(Description = "ManualMapping"), BenchmarkCategory("Class")]
    public MyClass ManualMapping_Class() => ManualMapper.MapToClass(_myClassDto);

    [Benchmark(Description = "Mapperly"), BenchmarkCategory("Class")]
    public MyClass Mapperly_Class() => MapperlyMapperOld.MapToClass(_myClassDto);

    [Benchmark(Description = "MapperlyAggressiveInlining"), BenchmarkCategory("Class")]
    public MyClass MapperlyAggressiveInlining_Class() => MapperlyMapperAggressiveInlining.MapToClass(_myClassDto);
    #endregion

    #region Struct

    [Benchmark(Description = "ManualMapping"), BenchmarkCategory("Struct")]
    public MyStruct ManualMapping_Struct() => ManualMapper.MapToStruct(_myStructDto);

    [Benchmark(Description = "Mapperly"), BenchmarkCategory("Struct")]
    public MyStruct Mapperly_Struct() => MapperlyMapperOld.MapToStruct(_myStructDto);

    [Benchmark(Description = "MapperlyAggressiveInlining"), BenchmarkCategory("Struct")]
    public MyStruct MapperlyAggressiveInlining_Struct() => MapperlyMapperAggressiveInlining.MapToStruct(_myStructDto);
    #endregion
}