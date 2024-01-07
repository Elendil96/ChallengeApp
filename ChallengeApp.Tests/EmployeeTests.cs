namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void EmployeeCollectsGrades_ShouldReturnCorrectMax()
        {
            //arrange
            var employee = new Employee("Micha³", "Banan");
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(2);


            //act
            var result = employee.GetStatistics();

            //assert

            Assert.AreEqual(6, result.Max);
        }

        [Test]
        public void EmployeeCollectsGrades_ShouldReturnCorrectMin()

        {
            //arrange
            var employee = new Employee("Micha³", "Banan");
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(2);


            //act
            var result = employee.GetStatistics();

            //assert

            Assert.AreEqual(2, result.Min);
        }

        [Test]
        public void EmployeeCollectsGrades_ShouldReturnCorrectAverage()
        {
            //arrange
            var employee = new Employee("Micha³", "Banan");
            employee.AddGrade(6);
            employee.AddGrade(4);
            employee.AddGrade(2);


            //act
            var result = employee.GetStatistics();

            //assert

            Assert.AreEqual(4, result.Average);
        }
    }
}