namespace UniversityPatterns.Domain.Programs;

public sealed class HardcoreCrammingProgram : IProgram
{
    public string Name => "Зубрене до скъсване";
    public string Description => Name;
    public int    FocusCost => 95;
    public int    EthicsScore => 0;

    public void PerformCoreWork()
    {
        Console.WriteLine("🤯 Memorizing non-stop, flashcards, repetition loops.");
    }
}