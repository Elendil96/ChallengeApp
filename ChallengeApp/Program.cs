using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny praconików");
Console.WriteLine("======================================");
Console.WriteLine();

var employee = new Employee("Marek", "Golan");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if(input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statisctics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"AVG: {statisctics.Average}");
Console.WriteLine($"MIN: {statisctics.Min}");
Console.WriteLine($"MAX: {statisctics.Max}");
Console.WriteLine($"AVG LETTER: {statisctics.AverageLetter}");

