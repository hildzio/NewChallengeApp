using System.Reflection.Metadata;

namespace NewChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldReturnCorrectResult()
        {
            //arrange
            var user = new User("Adam", "haslo123");
            user.AddScore(5);
            user.AddScore(6);
            //act
            int result = user.Result;
            //assert
            Assert.AreEqual(11, result);
        }

        [Test]
        public void WhenUserCollectScoresEqualZero_ShouldReturnZero()
        {
            //arrange
            var user = new User("Janek", "haslo123");
            user.AddScore(5);
            user.AddScore(6);
            user.AddScore(-11);
            //act
            int result = user.Result;
            //assert
            Assert.AreEqual(0, result);
        }
        [Test]
        public void WhenUserCollectMinusFromResult_ShouldReturnZero()
        {
            //arrange
            var user = new User("Krzysztof", "haslo123");
            user.AddScore(5);
            user.AddScore(6);
            user.AddNegativeScore(11);
            user.AddScore(8);
            user.AddScore(2);
            user.AddNegativeScore(4);
            user.AddNegativeScore(6);
            //act
            int result = user.Result;
            //assert
            Assert.AreEqual(0, result);
        }
    }
}