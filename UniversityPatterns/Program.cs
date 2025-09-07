using UniversityPatterns.Application;
using UniversityPatterns.ConsoleUi;
using UniversityPatterns.Domain.Entities;
using UniversityPatterns.Domain.Enums;

namespace UniversityPatterns;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        var uni = University.Instance;

        Console.WriteLine("==============================================");
        Console.WriteLine("  UniversityPatterns – Console UI");
        Console.WriteLine("  Patterns: Singleton, Factory+Decorator, Strategy");
        Console.WriteLine("==============================================\n");

        var students = new List<Student>();

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("  1) Add student");
            Console.WriteLine("  2) Run all");
            Console.WriteLine("  3) Quick demo (3 preset students)");
            Console.WriteLine("  0) Exit");

            var choice = Input.ReadInt("Your choice: ", 0, 3);
            Console.WriteLine();

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Bye!");
                    return;

                case 1:
                {
                    var name = Input.ReadNonEmpty("Name: ", "Студент");
                    Console.WriteLine();

                    var pType = EnumMenus.ChooseProgramType();
                    Console.WriteLine();

                    var profile = EnumMenus.ChooseProfileType();
                    Console.WriteLine();

                    var location = EnumMenus.ChooseLocation();
                    Console.WriteLine();

                    var s = new Student(name, pType, profile, location);
                    students.Add(s);
                    Console.WriteLine($"➕ Added: {name} ({pType}, {profile}, {location})\n");
                    break;
                }

                case 2:
                {
                    if (students.Count == 0)
                    {
                        Console.WriteLine("No students yet. Add at least one.\n");
                        break;
                    }

                    RunStudents(uni, students);
                    break;
                }

                case 3:
                {
                    var demo = new List<Student>
                    {
                        new("Иван", ProgramType.Understanding, ProfileType.Teamwork, Location.Home),
                        new("Мария", ProgramType.HardcoreCramming, ProfileType.Solo, Location.Cafe),
                        new("Георги", ProgramType.AdvancedCheating, ProfileType.Teamwork, Location.Corridor),
                    };
                    RunStudents(uni, demo);
                    break;
                }
            }
        }
    }

    static void RunStudents(University uni, IEnumerable<Student> students)
    {
        foreach (var s in students)
        {
            uni.Welcome(s);
            uni.ExecuteIndividualProgram(s);
        }
        Console.WriteLine("✅ Finished students.\n");
    }
}