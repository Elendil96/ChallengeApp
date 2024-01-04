namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectPostiveScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Micha³", "Banan", "32");
            employee.AddScore(6);
            employee.AddScore(2);
            employee.AddScore(8);
            employee.AddScore(3);

            //act
            var result = employee.Result;

            //assert

            Assert.AreEqual(19, result);
        }

        [Test]
        public void WhenEmployeeCollectNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Micha³", "Banan", "32");
            employee.AddScore(-6);
            employee.AddScore(-2);
            employee.AddScore(-2);
            employee.AddScore(-2);

            //act
            var result = employee.Result;

            //assert

            Assert.AreEqual(-12, result);
        }

        [Test]
        public void WhenEmployeeCollectPositiveScoresAndNegativeScores_ShouldCorrectResult()
        {
            //arrange
            var employee = new Employee("Micha³", "Banan", "32");
            employee.AddScore(6);
            employee.AddScore(-2);
            employee.AddScore(4);
            employee.AddScore(-7);

            //act
            var result = employee.Result;

            //assert

            Assert.AreEqual(1, result);

        }
    }
}