namespace UniversityPatterns.Domain.Programs;

public interface IProgram
{
    string Name { get; }
    string Description { get; }
    int    FocusCost { get; }
    int    EthicsScore { get; }
    void   PerformCoreWork();
}