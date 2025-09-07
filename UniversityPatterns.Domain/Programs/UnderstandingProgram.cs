namespace UniversityPatterns.Domain.Programs;

public sealed class UnderstandingProgram : IProgram
{
    public string Name => "Учене с разбиране";
    public string Description => Name;   // Decorator ще добавя профила по-късно
    public int    FocusCost => 60;       // абстрактна метрика 1..100 (умора/фокус)
    public int    EthicsScore => 100;    // -100..100 (етичност)

    public void PerformCoreWork()
    {
        Console.WriteLine("📚 Deep-diving into concepts, solving problems, making notes.");
    }
}