using System.Security.Cryptography.X509Certificates;

namespace NewChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareTwoReferences_ShouldReturnTrue()
        {
            //arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            //assert
            Assert.AreEqual(user1.Login, user2.Login);
        }
        [Test]
        public void CompareTwoReferences_ShouldReturnTrue1()
        {
            var user1 = GetUser("Adam", "Haslo123");
            var user2 = GetUser("Adam", "Haslo123");
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void CompareTwoReferences_ShouldReturnTrue2()
        {
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void CompareTwoInts_ShouldReturnTrue()
        {
            //arrange
            int number1 = 12;
            int number2 = 45;
            //act
            //assert
            Assert.AreNotEqual(number1, number2);
        }
        [Test]
        public void CompareTwoFloats_ShouldReturnTrue()
        {
            float number1 = 12.3f;
            float number2 = 12.3f;
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void CompareTwoStrings_ShouldReturnTrue()
        {
            string name1 = "KursProgramowania";
            string name2 = "KursSzybownictwa";
            Assert.AreNotEqual(name1, name2);
        }
        private User GetUser(string name)
        {
            return new User(name);
        }
        private User GetUser(string login, string password)
        {
            return new User(login, password);
        }
    }
}
