using UniversityPatterns.Domain.Entities;
using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Strategies;

public sealed class CafeStrategy : IExecutionStrategy
{
    public void Execute(Student student, IProgram program)
    {
        Console.WriteLine("☕ Ambient noise, limited power sockets, variable focus.");
        int effectiveFocus = Math.Max(1, program.FocusCost - 15);
        MetricsHelper.Print(program, effectiveFocus, distraction: 20);

        program.PerformCoreWork();
        Console.WriteLine($"✅ {student.Name} makes partial progress at the cafe.\n");
    }
}