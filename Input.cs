using System.Diagnostics;
using System.Text;

namespace AdventOfCode;

internal class Input
{
    static readonly Dictionary<string, string> dict = new()
        {
            { "0",  "0" },
            { "1",  "1" },
            { "2",  "2" },
            { "3",  "3" },
            { "4",  "4" },
            { "5",  "5" },
            { "6",  "6" },
            { "7",  "7" },
            { "8",  "8" },
            { "9",  "9" },
            { "zero", "0" },
            { "one",  "1" },
            { "two",  "2" },
            { "three", "3" },
            { "four",  "4" },
            { "five",  "5" },
            { "six",  "6" },
            { "seven",  "7" },
            { "eight",  "8" },
            { "nine",  "9" },
        };

    public int SumOfNumber()
    {
        var lines = File.ReadAllLines("input/input.txt", Encoding.UTF8);
        var sum = 0;

        foreach (var line in lines)
        {
            var first = GetFirst(line);
            var last = GetLast(line);
            sum += int.Parse($"{first}{last}");
            Debug.WriteLine($"{first}{last}");
        }

        return sum;
    }

    private static string GetLast(string line)
    {
        var last = dict.Select(kvp => new
        {
            value = kvp.Value,
            index = line.LastIndexOf(kvp.Key),
        }).Where(i => i.index >= 0).OrderByDescending(i => i.index).First();
        return last.value;
    }

    private static string GetFirst(string line)
    {
        var first = dict.Select(kvp => new
        {
            value = kvp.Value,
            index = line.IndexOf(kvp.Key),
        }).Where(i => i.index >= 0).OrderBy(i => i.index).First();
        return first.value;
    }
}
