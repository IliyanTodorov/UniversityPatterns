using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Strategies;

internal static class MetricsHelper
{
    public static void Print(IProgram program, int effectiveFocus, int distraction)
    {
        Console.WriteLine($"   • Base Focus: {program.FocusCost}");
        Console.WriteLine($"   • Ethics: {program.EthicsScore}");
        Console.WriteLine($"   • Effective Focus (after location): {effectiveFocus}");
        Console.WriteLine($"   • Distraction Level: {distraction}\n");
    }
}