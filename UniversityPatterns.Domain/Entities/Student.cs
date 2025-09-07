using UniversityPatterns.Domain.Enums;

namespace UniversityPatterns.Domain.Entities;

public sealed class Student
{
    public string Name { get; }
    public ProgramType ProgramType { get; }
    public ProfileType ProfileType { get; }
    public Location Location { get; }

    public Student(string name, ProgramType programType, ProfileType profileType, Location location)
    {
        Name = name;
        ProgramType = programType;
        ProfileType = profileType;
        Location = location;
    }
}