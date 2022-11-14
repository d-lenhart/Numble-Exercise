using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuadaxCodingAssessment;
using System;
using System.Linq;


namespace QuadaxCodingAssessmentTests
{
    [TestClass]
    public class MethodTests
    {
        Methods methods = new Methods();

        [TestMethod]
        public void IsValidNumber_WithEmptyUserGuess_ReturnsFalse()
        {
            {
                string userGuess = "";
                
                bool result = methods.IsValidNumber(userGuess);
                
                Assert.IsFalse(result, "Empty user guess should return invalid");
            }
        }

        [TestMethod]
        public void IsValidNumber_WithLengthOfThree_ReturnsFalse()
        {
            {
                string userGuess = "425";

                bool result = methods.IsValidNumber(userGuess);

                Assert.IsFalse(result, "User guess is too short, should return invalid");
            }
        }

        [TestMethod]
        public void IsValidNumber_WithLengthOfFive_ReturnsFalse()
        {
            {
                string userGuess = "61334";

                bool result = methods.IsValidNumber(userGuess);

                Assert.IsFalse(result, "User guess is too long, should return invalid");
            }
        }

        [TestMethod]
        public void IsValidNumber_WithUpperEdgeCase_ReturnsFalse()
        {
            {
                string userGuess = "6667";

                bool result = methods.IsValidNumber(userGuess);

                Assert.IsFalse(result, "User guess above number range should return invalid");
            }
        }

        [TestMethod]
        public void IsValidNumber_WithLowerEdgeCase_ReturnsFalse()
        {
            {
                string userGuess = "1110";

                bool result = methods.IsValidNumber(userGuess);

                Assert.IsFalse(result, "User guess lower number range should return invalid");
            }
        }

        [TestMethod]
        public void CheckGuess_SameNumberAndLocation_ReturnsPlusSign()
        {
            string userGuess = "2466";
            string generatedAnswer = "3415";

            string result = methods.CheckGuess(userGuess, generatedAnswer);

            Assert.AreEqual(" +  ", result, "The two values did not return as same number and location");
            
        }

        [TestMethod]
        public void CheckGuess_SameNumberDifferentLocation_ReturnsMinusSign()
        {
            string userGuess = "2466";
            string generatedAnswer = "3145";

            string result = methods.CheckGuess(userGuess, generatedAnswer);

            Assert.AreEqual(" -  ", result, "The two values did not return as same number, different location");

        }

        [TestMethod]

        public void CheckGuess_NumberNotPresent_ReturnsEmptyChar()
        {
            string userGuess = "2466";
            string generatedAnswer = "3135";

            string result = methods.CheckGuess(userGuess, generatedAnswer);

            Assert.AreEqual("    ", result, "The two values did not return all four empty chars");

        }
    }
}
