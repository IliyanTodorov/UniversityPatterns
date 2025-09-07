using UniversityPatterns.Domain.Entities;
using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Strategies;

public sealed class HomeStrategy : IExecutionStrategy
{
    public void Execute(Student student, IProgram program)
    {
        Console.WriteLine("🏠 Comfortable environment, long sessions possible.");
        int effectiveFocus = Math.Min(100, program.FocusCost + 10);
        MetricsHelper.Print(program, effectiveFocus, distraction: 5);

        program.PerformCoreWork();
        Console.WriteLine($"🎯 {student.Name} achieves solid outcomes at home.\n");
    }
}