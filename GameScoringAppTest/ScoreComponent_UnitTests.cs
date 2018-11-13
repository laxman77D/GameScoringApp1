using GameScoringApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GameScoringAppTest
{
    [TestClass]
    public class GameScoringAppUnitTest
    {
        [TestMethod]
        public void TestCalculateScoreCase1()
        {
            ScoreComponent obj = new ScoreComponent();
            List<string> blocks = new List<string>(new string[] { "5", "-2", "4", "Z", "X", "9", "+", "+" });
            int result = obj.CalculateScore(blocks, blocks.Count);
            Assert.AreEqual(27, result);
        }

        [TestMethod]
        public void TestCalculateScoreforFailure()
        {
            ScoreComponent obj = new ScoreComponent();
            List<string> blocks = new List<string>(new string[] { "1", "2", "+", "Z" });
            int result = obj.CalculateScore(blocks, blocks.Count);
            Assert.AreNotEqual(27, result);
        }

        [TestMethod]
        public void TestCalculateScoreforCase2()
        {
            ScoreComponent obj = new ScoreComponent();
            List<string> blocks = new List<string>(new string[] { "1", "2", "+", "Z" });
            int result = obj.CalculateScore(blocks, blocks.Count);
            Assert.AreEqual(3, result);
        }
    }
}
