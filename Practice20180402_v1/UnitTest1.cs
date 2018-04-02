using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice20180402_v1
{
    [TestClass]
    public class TennisGameTests
    {
        [TestMethod]
        public void Love_All()
        {
            TennisGame tennisGame = new TennisGame();
            string score = tennisGame.Score();
            Assert.AreEqual("Love All", score);
        }
    }
}
