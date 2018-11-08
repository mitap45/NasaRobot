using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaRobot;

namespace UnitTest
{
    [TestClass]
    public class RobotBoundaryValidation
    {
        [TestMethod]
        public void CorrectBoundaryValidation()
        {
            Assert.IsTrue(RobotValidation.isBoundaryValid("1 2"));
        }

        [TestMethod]
        public void StringBoundaryValidation()
        {
            Assert.IsFalse(RobotValidation.isBoundaryValid("a b"));
        }

        [TestMethod]
        public void StringIntegerBoundaryValidation()
        {
            Assert.IsFalse(RobotValidation.isBoundaryValid("a 5"));
        }

        [TestMethod]
        public void TooManyCharacterBoundaryValidation()
        {
            Assert.IsFalse(RobotValidation.isBoundaryValid("1 2 3"));
        }

        [TestMethod]
        public void InvalidCharacterBoundaryValidation()
        {
            Assert.IsFalse(RobotValidation.isBoundaryValid("/ -"));
        }


    }
}
