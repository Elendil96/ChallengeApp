using System;
using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;

        }

        public string name { get; private set; }
        public string surname { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine($"Wrong grade value. {grade} is out of range");
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float reuslt))
            {
                this.AddGrade(reuslt);
            }
            else
            {
                Console.WriteLine($"Grade {grade} is not a float");
            }
        }

        public void AddGrade(double grade)
        {

            this.AddGrade((float)grade);
        }
        public void AddGrade(long grade)
        {
            this.AddGrade((float)grade);
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
