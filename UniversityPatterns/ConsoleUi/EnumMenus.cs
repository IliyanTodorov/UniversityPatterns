using UniversityPatterns.Domain.Enums;

namespace UniversityPatterns.ConsoleUi;

internal static class EnumMenus
{
    public static ProgramType ChooseProgramType()
    {
        Console.WriteLine("Choose Program Type:");
        Console.WriteLine("  0) Understanding (Учене с разбиране)");
        Console.WriteLine("  1) AdvancedCheating (Преписване за напреднали)");
        Console.WriteLine("  2) HardcoreCramming (Зубрене до скъсване)");
        var n = Input.ReadInt("Your choice: ", 0, 2);
        return (ProgramType)n;
    }

    public static ProfileType ChooseProfileType()
    {
        Console.WriteLine("Choose Profile:");
        Console.WriteLine("  0) Teamwork (Работа в екип)");
        Console.WriteLine("  1) Solo (Соло изпълнител)");
        var n = Input.ReadInt("Your choice: ", 0, 1);
        return (ProfileType)n;
    }

    public static Location ChooseLocation()
    {
        Console.WriteLine("Choose Location:");
        Console.WriteLine("  0) Cafe (Кафене)");
        Console.WriteLine("  1) Corridor (Коридор)");
        Console.WriteLine("  2) Home (Вкъщи)");
        var n = Input.ReadInt("Your choice: ", 0, 2);
        return (Location)n;
    }
}