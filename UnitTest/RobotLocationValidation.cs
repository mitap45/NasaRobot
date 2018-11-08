using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaRobot;

namespace UnitTest
{
    [TestClass]
    public class RobotLocationValidation
    {
        [TestMethod]
        public void CorrectLocationValidation()
        {
            Assert.IsTrue(RobotValidation.isLocationValid("1 2 N"));
        }

        [TestMethod]
        public void TooManyCharacterLocationValidation()
        {
            Assert.IsFalse(RobotValidation.isLocationValid("3 4 S 2 N"));
        }

        [TestMethod]
        public void InvalidCharacterLocationValidation()
        {
            Assert.IsFalse(RobotValidation.isLocationValid("- / &"));
        }

        [TestMethod]
        public void WrongDirectionLocationValidation()
        {
            Assert.IsFalse(RobotValidation.isLocationValid("1 2 C"));
        }

        [TestMethod]
        public void StringLocationValidation()
        {
            Assert.IsFalse(RobotValidation.isLocationValid("a b c"));
        }

    }
}
