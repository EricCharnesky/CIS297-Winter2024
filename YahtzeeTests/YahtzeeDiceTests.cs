using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahtzeeTests;

namespace Yahtzee.Tests
{
    [TestClass()]
    public class YahtzeeDiceTests
    {
        [TestMethod()]
        public void GetPossibleScoresTestUpperSection()
        {
            // Arrange
            List<int> expectedValues = new List<int> { 1, 2, 3, 4, 5 };
            NotRandom values = new NotRandom(expectedValues);
            YahtzeeDice dice = new YahtzeeDice(values);
            dice.Roll();
            int expectedOnesScore = 1;
            int expectedTwosScore = 2;
            int expectedThreesScore = 3;
            int expectedFoursScore = 4;
            int expectedFivesScore = 5;
            int expectedSixesScore = 0;


            // Act
            YahtzeeScorecard actualScores = dice.GetPossibleScores();

            // Assert
            Assert.AreEqual(actualScores.OnesScore, expectedOnesScore);
            Assert.AreEqual(actualScores.TwosScore, expectedTwosScore);
            Assert.AreEqual(actualScores.ThreesScore, expectedThreesScore);
            Assert.AreEqual(actualScores.FoursScore, expectedFoursScore);
            Assert.AreEqual(actualScores.FivesScore, expectedFivesScore);
            Assert.AreEqual(actualScores.SixesScore, expectedSixesScore);
        }

        [TestMethod()]
        public void GetPossibleScoresTestThreeOfAKind()
        {
            // Arrange
            List<int> expectedValues = new List<int> { 1, 1, 1, 4, 5 };
            NotRandom values = new NotRandom(expectedValues);
            YahtzeeDice dice = new YahtzeeDice(values);
            dice.Roll();
            int expectedThreeOfAKind = 12;


            // Act
            YahtzeeScorecard actualScores = dice.GetPossibleScores();

            // Assert
            Assert.AreEqual(actualScores.ThreeOfAKind, expectedThreeOfAKind);
        }
    }
}