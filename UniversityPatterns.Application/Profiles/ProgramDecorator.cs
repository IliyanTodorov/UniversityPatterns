using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Profiles;

public abstract class ProgramDecorator : IProgram
{
    protected readonly IProgram Inner;

    protected ProgramDecorator(IProgram inner)
    {
        Inner = inner;
    }

    public virtual string Name => Inner.Name;
    public virtual string Description => Inner.Description;
    public virtual int    FocusCost => Inner.FocusCost;
    public virtual int    EthicsScore => Inner.EthicsScore;

    public virtual void PerformCoreWork() => Inner.PerformCoreWork();
}