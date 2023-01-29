namespace NewChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void AverageFromEmployeeGrades_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Adam", "haslo123",28);
            employee.AddGrade(5);
            employee.AddGrade(6);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(5.5, statistics.Average);
        }
        [Test]
        public void CheckMinAndMaxMethod_ShouldReturnCorrectResult()
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
        }
    }
}
