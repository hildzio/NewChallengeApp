namespace NewChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void CheckMinMaxAverageMethod_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new EmployeeInMemory("Jan", "haslo123", 35, 'M');
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
        [Test]
        public void CheckAddGradeWithStringAndAverageLetter_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new EmployeeInMemory("Jan", "haslo123", 35, 'M');
            employee.AddGrade("40");
            employee.AddGrade("42");
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(41, statistics.Average);
            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void CheckAddGradeWithIntAndAverageLetter_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new EmployeeInMemory("Jan", "haslo123", 35, 'M');
            employee.AddGrade(20);
            employee.AddGrade(80);
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(50, statistics.Average);
            Assert.AreEqual('C', statistics.AverageLetter);
        }
        [Test]
        public void CheckAddGradeWithCharAndAverageLetter_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new EmployeeInMemory("Jan", "haslo123", 35, 'M');
            employee.AddGrade('a');
            employee.AddGrade('B');
            //act
            var statistics = employee.GetStatistics();
            //assert
            Assert.AreEqual(90, statistics.Average);
            Assert.AreEqual('A', statistics.AverageLetter);

        }

    }
}
