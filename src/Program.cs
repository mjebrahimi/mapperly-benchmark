using BenchmarkDotNetVisualizer;
using Mapperly_Benchmark.Benchmark1;
using Mapperly_Benchmark.Benchmark2;

var summary1 = BenchmarkAutoRunner.Run<Benchmark1>();
await summary1.SaveAsImageAsync(
    path: DirectoryHelper.GetPathRelativeToProjectDirectory("Benchmark1.png"),
    options: new ReportHtmlOptions
    {
        Title = "Mapperly vs MapperlyAggressiveInlining Benchmark1",
        GroupByColumns = ["Categories"],
        SpectrumColumns = ["Mean", "Allocated"],
        SortByColumns = ["Mean", "Allocated"],
        HighlightGroups = true,
    });

var summary2 = BenchmarkAutoRunner.Run<Benchmark2>();
await summary2.SaveAsImageAsync(
    path: DirectoryHelper.GetPathRelativeToProjectDirectory("Benchmark2.png"),
    options: new ReportHtmlOptions
    {
        Title = "Mapperly vs MapperlyAggressiveInlining Benchmark2",
        GroupByColumns = ["Categories"],
        SortByColumns = ["Mean", "Allocated",],
        SpectrumColumns = ["Mean", "Allocated",],
        HighlightGroups = true,
    });

Console.ReadLine();