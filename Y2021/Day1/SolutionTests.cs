using Xunit;

namespace AdventOfCode.Y2021.Day1;

public class SolutionTests {

    [Fact]
    public void Example_1()
    {
        var report = new[] {
            199,200,208,210,200,207,240,269,260,263
        };
        const int expected = 7;

        Assert.Equal(expected, Solution.MeasureCountOfDepthIncreases(report));
    }

    [Fact]
    public void Example_2()
    {
        var report = new[] {
            199, 200, 208, 210, 200, 207, 240, 269, 260, 263
        };
        const int expected = 5;
        
        Assert.Equal(expected, Solution.MeasureCountOfThreeMeasurementWindowsIncreases(report));
    }
}
