using Leet.Solutions;

namespace Leet.Tests;

public class SolutionsTests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 3, 6, 10 })]
    [InlineData(new[] { 1, 1, 1, 1, 1 }, new[] { 1, 2, 3, 4, 5 })]
    [InlineData(new[] { 3, 1, 2, 10, 1 }, new[] { 3, 4, 6, 16, 17 })]
    public void IsRunningSum(int[] input, int[] output)
    {
        var runningSum = Solutions.Solutions.RunningSum(input);

        Assert.Equal(output, runningSum);
    }

    [Theory]
    [InlineData(new[] { 1, 7, 3, 6, 5, 6 }, 3)]
    [InlineData(new[] { 1, 2, 3 }, -1)]
    [InlineData(new[] { 2, 1, -1 }, 0)]
    public void IsPivotIndex(int[] input, int output)
    {
        var pivotIndex = Solutions.Solutions.PivotIndex(input);

        Assert.Equal(output, pivotIndex);
    }

    [Theory]
    [InlineData("egg", "add", true)]
    [InlineData("badc", "baba", false)]
    [InlineData("paper", "title", true)]
    public void IsIsomorphic(string s, string t, bool outcome)
    {
        var isIsomorphic = Solutions.Solutions.IsIsomorphic(s, t);

        Assert.Equal(outcome, isIsomorphic);
    }
}