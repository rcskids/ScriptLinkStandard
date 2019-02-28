using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.ObjectsTests
{
    [TestClass]
    public class RowActionTests
    {
        [TestMethod]
        public void RowAction_Returns_ADD()
        {
            Assert.AreEqual("ADD", RowAction.Add);
        }

        [TestMethod]
        public void RowAction_Returns_DELETE()
        {
            Assert.AreEqual("DELETE", RowAction.Delete);
        }

        [TestMethod]
        public void RowAction_Returns_EDIT()
        {
            Assert.AreEqual("EDIT", RowAction.Edit);
        }

        [TestMethod]
        public void RowAction_Returns_Blank()
        {
            Assert.AreEqual("", RowAction.None);
        }
    }
}
