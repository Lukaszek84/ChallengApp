namespace ChallengApp.tests
{
    public class Tests
    {
        [Test]
        public void CheckAddition()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski", 38);
            employee.AddScore(10);
            employee.AddScore(4);
            employee.AddScore(6);
            employee.AddScore(5);
            employee.AddScore(6);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(31, result);
        }
        [Test]
        public void CheckAdditionAndCapture()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski", 38);
            employee.AddScore(10);
            employee.AddScore(-4);
            employee.AddScore(-6);
            employee.AddScore(-5);
            employee.AddScore(-6);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(-11, result);
        }
        [Test]
        public void CheckAdditionAndCapture2()
        {
            // arrange
            var employee = new Employee("Jan", "Kowalski", 38);
            employee.AddScore(-10);
            employee.AddScore(-4);
            employee.AddScore(-6);
            employee.AddScore(-5);
            employee.AddScore(-6);
            // act
            var result = employee.Result;
            // assert
            Assert.AreEqual(-31, result);
        }

    }
}