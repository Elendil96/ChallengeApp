using ChallengeApp;

var employee = new Employee("Darek", "Nowak");

employee.AddGrade(2);
employee.AddGrade(8);
employee.AddGrade(2);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
