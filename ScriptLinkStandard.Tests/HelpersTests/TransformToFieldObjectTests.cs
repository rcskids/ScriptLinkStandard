using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToFieldObjectTests
    {
        [TestMethod]
        [TestCategory("FieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FieldObjectFromJson_NullString()
        {
            string json = null;
            FieldObject expected = new FieldObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToFieldObject(json));
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjectFromJson_Success()
        {
            string json = "{\"Enabled\":\"0\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"0\",\"Required\":\"0\"}";
            FieldObject expected = new FieldObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToFieldObject(json));
        }

        [TestMethod]
        [TestCategory("FieldObject")]
        public void FieldObjectFromJson_Failure()
        {
            string json = "{\"Enabled\":\"0\",\"FieldNumber\":\"\",\"FieldValue\":\"\",\"Lock\":\"0\",\"Required\":\"0\"}";
            FieldObject expected = new FieldObject
            {
                FieldNumber = "1"
            };
            Assert.AreNotEqual(expected, ScriptLinkHelpers.TransformToFieldObject(json));
        }
    }
}
