using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice20180402_v1
{
    [TestClass]
    public class TennisGameTests
    {
        private TennisGame tennisGame = new TennisGame();

        [TestMethod]
        public void Love_All()
        {
            ScoreShouldBe("Love All");
        }

        [TestMethod]
        public void Fifteen_Love()
        {
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Fifteen Love");
        }

        [TestMethod]
        public void Thirty_Love()
        {
            tennisGame.FirstPlayerScore();
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Thirty Love");
        }

        [TestMethod]
        public void Forty_Love()
        {
            tennisGame.FirstPlayerScore();
            tennisGame.FirstPlayerScore();
            tennisGame.FirstPlayerScore();
            ScoreShouldBe("Forty Love");
        }
        private void ScoreShouldBe(string expected)
        {
            string score = tennisGame.Score();
            Assert.AreEqual(expected, score);
        }
    }
}