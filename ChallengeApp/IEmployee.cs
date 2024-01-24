namespace ChallengeApp
{
    public interface IEmployee
    {
        public string Name { get; }

        public string Surname { get; }

        public string Sex { get; }

        void AddGrade(float grade);

        void AddGrade(double grade);

        void AddGrade(string grade);

        Statistics GetStatistics();
    }
}
