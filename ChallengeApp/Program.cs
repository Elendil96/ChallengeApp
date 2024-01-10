using ChallengeApp;

var employee = new Employee("Darek", "Nowak");

employee.AddGrade("1000");
employee.AddGrade("Mario");
employee.AddGrade(2);
employee.AddGrade(200000000000000);
employee.AddGrade(2);
employee.AddGrade(2.5);

var statistics = employee.GetStatistics();

Console.WriteLine("");
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
