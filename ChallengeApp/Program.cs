using ChallengeApp;

var employee = new Employee("Darek", "Nowak");

employee.AddGrade("1000");
employee.AddGrade("Mario");
employee.AddGrade(2);
employee.AddGrade(200000000000000);
employee.AddGrade(2);
employee.AddGrade(2.5);

var statistics = employee.GetStatistics();
var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithForEach();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"\nAverage: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

Console.WriteLine($"\nWyniki dla pętli for");
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

Console.WriteLine($"\nWyniki dla pętli foreach");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

Console.WriteLine($"\nWyniki dla pętli while");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

Console.WriteLine($"\nWyniki dla pętli do while");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");