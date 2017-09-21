using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.ObjectsTests
{
    [TestClass]
    public class RowObjectTests
    {
        private RowObject rowObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.rowObject = new RowObject();
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void NewRowObjectHasFieldsObject()
        {
            Assert.IsNotNull(rowObject.Fields);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void NewRowObjectFieldsObjectIsNotEmpty()
        {
            List<FieldObject> expected = new List<FieldObject>();
            var actual = rowObject.Fields;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void NewRowObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void NewRowObject_CanGetHtmlString_WithHtmlHeaders()
        {
            var actual = rowObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }
    }
}
