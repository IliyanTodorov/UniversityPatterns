using System.Globalization;

namespace UniversityPatterns.ConsoleUi;

internal static class Input
{
    public static int ReadInt(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            var raw = Console.ReadLine();
            if (int.TryParse(raw, NumberStyles.Integer, CultureInfo.InvariantCulture, out var n) && n >= min && n <= max)
                return n;

            Console.WriteLine($"Please enter a number between {min} and {max}.\n");
        }
    }

    public static string ReadNonEmpty(string prompt, string fallback = "Студент")
    {
        Console.Write(prompt);
        var s = Console.ReadLine();
        return string.IsNullOrWhiteSpace(s) ? fallback : s.Trim();
    }
}