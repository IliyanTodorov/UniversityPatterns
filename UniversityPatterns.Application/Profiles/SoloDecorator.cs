using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Profiles;

public sealed class SoloDecorator : ProgramDecorator
{
    public SoloDecorator(IProgram inner) : base(inner) { }

    public override string Description => $"{Inner.Description} + Профил: соло изпълнител";

    public override void PerformCoreWork()
    {
        base.PerformCoreWork();
        Console.WriteLine("🧘 Focused individual practice, self-quizzing, personal pace.");
    }
}