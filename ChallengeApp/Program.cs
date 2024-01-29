using ChallengeApp;

Console.WriteLine("Witamy w programie do oceny praconików");
Console.WriteLine("======================================");
Console.WriteLine();

var employee = new EmployeeInFile("Marek", "Golan", "M");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }

    catch (Exception exception)
    {
        Console.WriteLine($"Exceptions catched {exception.Message}");
    }
}

var statisctics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"AVG: {statisctics.Average}");
Console.WriteLine($"MIN: {statisctics.Min}");
Console.WriteLine($"MAX: {statisctics.Max}");
Console.WriteLine($"AVG LETTER: {statisctics.AverageLetter}");
Console.WriteLine($"COUNT: {statisctics.Count}");
Console.WriteLine($"SUM: {statisctics.Sum}");
Console.WriteLine();