namespace ChallengeApp.Tests
{
   public class TypeTests
    {
        [Test]
        public void GetEmployeeShouldReturnDiffrentObjects()
        {
            //arrange
            var employee1 = GetEmployee("Marcin", "Jur");
            var employee2 = GetEmployee("Andrzej", "Gierer");

            //act


            //assert
            Assert.AreNotEqual(employee1.name, employee2.name);  

        }

        private Employee GetEmployee(string name, string surname)
        {
            return new Employee (name, surname);
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
