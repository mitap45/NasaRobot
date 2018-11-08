using Microsoft.VisualStudio.TestTools.UnitTesting;
using NasaRobot;

namespace UnitTest
{
    [TestClass]
    public class RobotCommandsValidation
    {
        [TestMethod]
        public void CorrectCommandValidation()
        {
            Assert.IsTrue(RobotValidation.isCommandsValid("MMRLLRMRLM"));
        }

        [TestMethod]
        public void InvalidCommandValidation()
        {
            Assert.IsFalse(RobotValidation.isCommandsValid("amrrmlrmmm"));
        }

        [TestMethod]
        public void InvalidCharacterCommandValidation()
        {
            Assert.IsFalse(RobotValidation.isCommandsValid("34mlrmmm"));
        }

    }
}
