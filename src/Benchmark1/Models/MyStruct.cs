namespace Mapperly_Benchmark.Benchmark1.Models;

public struct MyStruct
{
    public int Int { get; set; }
    public string String { get; set; }
    public bool Boolean { get; set; }
    public long Long { get; set; }
    public double Double { get; set; }
    public DateTime DateTime { get; set; }
    public MyEnum Enum { get; set; }
    public MySubStruct SubStruct { get; set; }
}

public struct MySubStruct
{
    public int Int { get; set; }
    public string String { get; set; }
}
