﻿namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = @"C:\Users\marci\OneDrive\Pulpit\Projekty\ChallengeApp\ChallengeApp\grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname, string sex)
            : base(name, surname, sex)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);

                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            else
            {
                throw new Exception($"{grade} - Invalid grade value");
            }
        }

        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char resultChar))
            {
                switch (resultChar)
                {
                    case 'A':
                    case 'a':
                        this.AddGrade(100);
                        break;
                    case 'B':
                    case 'b':
                        this.AddGrade(80);
                        break;
                    case 'C':
                    case 'c':
                        this.AddGrade(60);
                        break;
                    case 'D':
                    case 'd':
                        this.AddGrade(40);
                        break;
                    case 'E':
                    case 'e':
                        this.AddGrade(20);
                        break;
                    default:
                        throw new Exception($"{grade} - Wrong letter");
                }
            }
            else
            {
                throw new Exception($"{grade} - String in not float");
        }
    }

    public override Statistics GetStatistics()
    {
        var gradesFromFile = this.ReadGradesFromFile();
        var result = this.CountStatistics(gradesFromFile);
        return result;
    }

    private List<float> ReadGradesFromFile()
    {
        var grades = new List<float>();
        if (File.Exists($"{fileName}"))
        {
            using (var reader = File.OpenText($"{fileName}"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var number = float.Parse(line);
                    grades.Add(number);
                    line = reader.ReadLine();
                }
            }
        }

        return grades;
    }
    private Statistics CountStatistics(List<float> grades)
    {
        var statistics = new Statistics();

        foreach (var grade in grades)
        {
            statistics.AddGrade(grade);
        }

        return statistics;

    }
}
}