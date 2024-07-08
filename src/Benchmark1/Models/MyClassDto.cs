namespace Mapperly_Benchmark.Benchmark1.Models;

public class MyClassDto
{
    public int Int { get; set; }
    public string String { get; set; }
    public bool Boolean { get; set; }
    public long Long { get; set; }
    public double Double { get; set; }
    public DateTime DateTime { get; set; }
    public MyEnum Enum { get; set; }
    public MySubClassDto SubClass { get; set; }
}

public class MySubClassDto
{
    public int Int { get; set; }
    public string String { get; set; }
}