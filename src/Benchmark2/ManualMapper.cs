using Mapperly_Benchmark.Benchmark1.Models;

namespace Mapperly_Benchmark.Benchmark1;

public static class ManualMapper
{
    public static MyClass MapToClass(MyClassDto source)
    {
        return new MyClass
        {
            Int = source.Int,
            String = source.String,
            Boolean = source.Boolean,
            Long = source.Long,
            Double = source.Double,
            DateTime = source.DateTime,
            Enum = source.Enum,
            SubClass = new MySubClass
            {
                Int = source.SubClass.Int,
                String = source.SubClass.String
            }
        };
    }

    public static MyStruct MapToStruct(MyStructDto source)
    {
        return new MyStruct
        {
            Int = source.Int,
            String = source.String,
            Boolean = source.Boolean,
            Long = source.Long,
            Double = source.Double,
            DateTime = source.DateTime,
            Enum = source.Enum,
            SubStruct = new MySubStruct
            {
                Int = source.SubStruct.Int,
                String = source.SubStruct.String
            }
        };
    }
}
