using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToRowObjectTests
    {
        [TestMethod]
        [TestCategory("RowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void RowObjectFromJson_NullString()
        {
            string json = null;
            RowObject expected = new RowObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToFieldObject(json));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjectFromJson_Success()
        {
            string json = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            RowObject expected = new RowObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToRowObject(json));
        }

        [TestMethod]
        [TestCategory("RowObject")]
        public void RowObjectFromJson_Failure()
        {
            string json = "{\"Fields\":[],\"ParentRowId\":null,\"RowAction\":null,\"RowId\":null}";
            RowObject expected = new RowObject
            {
                RowId = "1||1"
            };
            Assert.AreNotEqual(expected, ScriptLinkHelpers.TransformToRowObject(json));
        }
    }
}
