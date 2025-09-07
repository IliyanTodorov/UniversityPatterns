using UniversityPatterns.Domain.Enums;
using UniversityPatterns.Domain.Programs;

namespace UniversityPatterns.Application.Terminal;

public sealed class Terminal
{
    public IProgram ChooseProgram(ProgramType type)
        => type switch
        {
            ProgramType.Understanding     => new UnderstandingProgram(),
            ProgramType.AdvancedCheating  => new AdvancedCheatingProgram(),
            ProgramType.HardcoreCramming  => new HardcoreCrammingProgram(),
            _                             => new UnderstandingProgram()
        };
}