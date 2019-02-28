using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class IsValidRowActionTests
    {
        [TestMethod]
        public void IsValidRowAction_Null()
        {
            string rowAction = null;
            Assert.IsFalse(ScriptLinkHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_Blank()
        {
            string rowAction = "";
            Assert.IsTrue(ScriptLinkHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_ADD()
        {
            string rowAction = "ADD";
            Assert.IsTrue(ScriptLinkHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_DELETE()
        {
            string rowAction = "DELETE";
            Assert.IsTrue(ScriptLinkHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_EDIT()
        {
            string rowAction = "EDIT";
            Assert.IsTrue(ScriptLinkHelpers.IsValidRowAction(rowAction));
        }
        [TestMethod]
        public void IsValidRowAction_QuestionMark()
        {
            string rowAction = "?";
            Assert.IsFalse(ScriptLinkHelpers.IsValidRowAction(rowAction));
        }
    }
}
