namespace ChallengeApp
{
    public class Employee
    {
        private List<int> grades = new List<int>();

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }

        public string name { get; private set; }
        public string surname { get; private set; }


        public void AddGrade(int number)
        {
            this.grades.Add(number);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            
            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;
        }
    }
}
