using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Test.ObjectsTests
{
    [TestClass]
    public class FieldObjectTests
    {
        private FieldObject newFieldObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.newFieldObject = new FieldObject();
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanSetAndGetEnabled()
        {
            var expected = "1";
            newFieldObject.Enabled = expected;
            var actual = newFieldObject.Enabled;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanSetAndGetFieldNumber()
        {
            var expected = "12345.0";
            newFieldObject.FieldNumber = expected;
            var actual = newFieldObject.FieldNumber;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanSetAndGetFieldValue()
        {
            var expected = "field value";
            newFieldObject.FieldValue = expected;
            var actual = newFieldObject.FieldValue;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanSetAndGetLock()
        {
            var expected = "0";
            newFieldObject.Lock = expected;
            var actual = newFieldObject.Lock;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanSetAndGetRequired()
        {
            var expected = "0";
            newFieldObject.Required = expected;
            var actual = newFieldObject.Required;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanGetHtmlString_WithoutHtmlHeaders()
        {
            var actual = newFieldObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void CanGetHtmlString_WithHtmlHeaders()
        {
            var actual = newFieldObject.ToHtmlString(true);
            Assert.IsNotNull(actual);
        }
    }
}
