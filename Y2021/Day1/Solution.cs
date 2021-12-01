namespace AdventOfCode.Y2021.Day1;

public class Solution {
    public static void Main()
    {
        var report = File.ReadAllLines("Y2021/Day1/input.txt")
            .Select(line => int.Parse(line.Trim()))
            .ToArray();
        Console.WriteLine($"Answer 1: {MeasureCountOfDepthIncreases(report)}");
        Console.WriteLine($"Answer 2: {MeasureCountOfThreeMeasurementWindowsIncreases(report)}");
    }
    public static int MeasureCountOfDepthIncreases(int[] report)
    {
        int? lastValue = null;
        var depthIncreasesCount = 0;
        foreach (var value in report)
        {
            if (lastValue < value)
            {
                depthIncreasesCount++;
            }

            lastValue = value;
        }
        return depthIncreasesCount;
    }

    public static int MeasureCountOfThreeMeasurementWindowsIncreases(int[] report)
    {
        int? lastSum = null;
        int[] sums = new int[3];
        int[] saves = new int[] {0,0,0};
        int increases = 0;
        for (int i = 0; i < report.Length; i++)
        {
            var iterations = i < 2 ? i + 1 : 3;
            for (var j = 0; j < iterations; j++)
            {
                sums[j] += report[i];
                saves[j]++;
                if (saves[j] == 3)
                {
                    if (lastSum < sums[j])
                    {
                        increases++;
                    }
                    lastSum = sums[j];
                    sums[j] = 0;
                    saves[j] = 0;
                }
            }
        }

        return increases;
    }
}
