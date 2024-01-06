namespace ChallengeApp.Tests
{
   public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnDiffrentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Marcin", "Jur", "20");
            var employee2 = GetEmployee("Andrzej", "Gierer", "57");

            //act


            //assert
            Assert.AreNotEqual(employee1.name, employee2.name);  

        }

        private Employee GetEmployee(string name, string surname, string age)
        {
            return new Employee (name, surname, age);
        }

        [Test]
        public void TestShouldReturnDiffrentStringNames()
        {
            //arrange
            string employee1 = ("Marcin");
            string employee2 = ("Andrzej");

            //act


            //assert
            Assert.AreNotEqual(employee1, employee2);

        }
        [Test]
        public void TestShouldReturnDiffrentIntNumbers()
        {
            //arrange
            int number1 = (24);
            int number2 = (45);

            //act


            //assert
            Assert.AreNotEqual(number1, number2);

        }
        [Test]
        public void TestShouldReturnDiffrentFloatNumbers()
        {
            //arrange
            float number3 = (24000000000);
            float number4 = (45000000000);

            //act


            //assert
            Assert.AreNotEqual(number3, number4);

        }
    }
}
