namespace Mapperly_Benchmark.Benchmark1.Models;

public struct MyStructDto
{
    public int Int { get; set; }
    public string String { get; set; }
    public bool Boolean { get; set; }
    public long Long { get; set; }
    public double Double { get; set; }
    public DateTime DateTime { get; set; }
    public MyEnum Enum { get; set; }
    public MySubStructDto SubStruct { get; set; }
}

public struct MySubStructDto
{
    public int Int { get; set; }
    public string String { get; set; }
}