using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class TransformToFormObjectTests
    {
        [TestMethod]
        [TestCategory("FormObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void FormObjectFromJson_NullString()
        {
            string json = null;
            FormObject expected = new FormObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToFieldObject(json));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObjectFromJson_Success()
        {
            string json = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new FormObject();
            Assert.AreEqual(expected, ScriptLinkHelpers.TransformToFormObject(json));
        }

        [TestMethod]
        [TestCategory("FormObject")]
        public void FormObjectFromJson_Failure()
        {
            string json = "{\"CurrentRow\":null,\"FormId\":null,\"MultipleIteration\":false,\"OtherRows\":[]}";
            FormObject expected = new FormObject
            {
                FormId = "1"
            };
            Assert.AreNotEqual(expected, ScriptLinkHelpers.TransformToFormObject(json));
        }
    }
}
