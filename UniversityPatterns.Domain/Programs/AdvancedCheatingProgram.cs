namespace UniversityPatterns.Domain.Programs;

public sealed class AdvancedCheatingProgram : IProgram
{
    public string Name => "Преписване за напреднали";
    public string Description => Name;
    public int    FocusCost => 10;
    public int    EthicsScore => -100;

    public void PerformCoreWork()
    {
        Console.WriteLine("🕵️ Crafting cheat sheets, syncing signals, risk management (bad idea!).");
    }
}