using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Profiles;

public sealed class TeamworkDecorator : ProgramDecorator
{
    public TeamworkDecorator(IProgram inner) : base(inner) { }

    public override string Description => $"{Inner.Description} + Профил: работа в екип";

    public override void PerformCoreWork()
    {
        base.PerformCoreWork();
        Console.WriteLine("🤝 Collaborating in a study group, pair discussions, shared notes.");
    }
}