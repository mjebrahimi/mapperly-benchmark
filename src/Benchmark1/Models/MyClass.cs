namespace Mapperly_Benchmark.Benchmark1.Models;

public class MyClass
{
    public int Int { get; set; }
    public string String { get; set; }
    public bool Boolean { get; set; }
    public long Long { get; set; }
    public double Double { get; set; }
    public DateTime DateTime { get; set; }
    public MyEnum Enum { get; set; }
    public MySubClass SubClass { get; set; }
}

public class MySubClass
{
    public int Int { get; set; }
    public string String { get; set; }
}

public enum MyEnum
{
    Enum1,
    Enum2,
    Enum3
}