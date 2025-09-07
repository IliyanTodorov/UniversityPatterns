using UniversityPatterns.Domain.Entities;
using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Strategies;

public sealed class CorridorStrategy : IExecutionStrategy
{
    public void Execute(Student student, IProgram program)
    {
        Console.WriteLine("🚶 Interruptions, short sessions between classes.");
        int effectiveFocus = Math.Max(1, program.FocusCost - 25);
        MetricsHelper.Print(program, effectiveFocus, distraction: 30);

        program.PerformCoreWork();
        Console.WriteLine($"⚠️ {student.Name} struggles with interruptions in the corridor.\n");
    }
}