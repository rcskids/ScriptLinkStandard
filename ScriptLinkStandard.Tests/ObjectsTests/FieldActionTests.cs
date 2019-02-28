using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.ObjectsTests
{
    [TestClass]
    public class FieldActionTests
    {
        [TestMethod]
        public void FieldAction_Returns_DISABLE()
        {
            Assert.AreEqual("DISABLE", FieldAction.Disable);
        }

        [TestMethod]
        public void FieldAction_Returns_LOCK()
        {
            Assert.AreEqual("LOCK", FieldAction.Lock);
        }

        [TestMethod]
        public void FieldAction_Returns_OPTIONAL()
        {
            Assert.AreEqual("OPTIONAL", FieldAction.Optional);
        }

        [TestMethod]
        public void FieldAction_Returns_REQUIRE()
        {
            Assert.AreEqual("REQUIRE", FieldAction.Require);
        }

        [TestMethod]
        public void FieldAction_Returns_UNLOCK()
        {
            Assert.AreEqual("UNLOCK", FieldAction.Unlock);
        }
    }
}
