namespace NewChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMinMaxAverageMethod_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Jan", "haslo123", 35);
            employee.AddGrade(1);
            employee.AddGrade(6);
            employee.AddGrade(9);
            employee.AddGrade(16);
            employee.AddGrade(21);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(1, statistics.Min);
            Assert.AreEqual(21, statistics.Max);
            Assert.AreEqual(10.6f, statistics.Average);
        }
    }
}
