using ChallengeApp;

Employee employee1 = new Employee("Darek", "Nowak", "34");
Employee employee2 = new Employee("Michał", "Gardka", "63");
Employee employee3 = new Employee("Oskar", "Łodyga", "19");


employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(8);
employee1.AddScore(7);
employee1.AddScore(1);

employee2.AddScore(6);
employee2.AddScore(8);
employee2.AddScore(9);
employee2.AddScore(1);
employee2.AddScore(7);

employee3.AddScore(1);
employee3.AddScore(9);
employee3.AddScore(2);
employee3.AddScore(8);
employee3.AddScore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
{
    if(employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}

Console.WriteLine("Pracownik, który osiągnął najwyższą liczbę punktów to " + employeeWithMaxResult.name + " " + employeeWithMaxResult.surname
    + " - lat " + employeeWithMaxResult.age + ". Zdobył zawrotną liczbę " + maxResult + " punktów.");
