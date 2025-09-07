using UniversityPatterns.Application.Profiles;
using UniversityPatterns.Application.Strategies;
using UniversityPatterns.Domain.Entities;
using UniversityPatterns.Domain.Enums;
using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application;

public sealed class University
{
    private static readonly Lazy<University> _instance = new(() => new University());
    public static University Instance => _instance.Value;

    public Terminal.Terminal Terminal { get; } = new();

    private University() { }

    public void Welcome(Student s)
        => Console.WriteLine($"Welcome, {s.Name}!");

    public void ExecuteIndividualProgram(Student s)
    {
        IProgram baseProgram = Terminal.ChooseProgram(s.ProgramType);
        
        IProgram profiledProgram = ApplyProfile(baseProgram, s.ProfileType);

        Console.WriteLine($"🧾 Selected: {profiledProgram.Description}");
        Console.WriteLine($"📍 Execution location: {s.Location}\n");
        
        IExecutionStrategy strategy = GetStrategy(s.Location);
        strategy.Execute(s, profiledProgram);

        Console.WriteLine(new string('-', 60));
    }
    
    private static IProgram ApplyProfile(IProgram program, ProfileType profileType)
    {
        return profileType switch
        {
            ProfileType.Teamwork => new TeamworkDecorator(program),
            ProfileType.Solo     => new SoloDecorator(program),
            _ => program
        };
    }
    
    private static IExecutionStrategy GetStrategy(Location location) => location switch
    {
        Location.Cafe => new CafeStrategy(),
        Location.Corridor => new CorridorStrategy(),
        _ => new HomeStrategy()
    };
}