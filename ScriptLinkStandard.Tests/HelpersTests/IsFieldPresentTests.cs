using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Test.HelpersTests
{
    [TestClass]
    public class IsFieldPresentTests
    {
        private OptionObject optionObject;
        private FormObject formObject;
        private RowObject rowObject;
        private FieldObject fieldObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.fieldObject = new FieldObject();
            fieldObject.Enabled = "1";
            fieldObject.FieldNumber = "123.45";
            fieldObject.FieldValue = "Test Value";
            fieldObject.Lock = "0";
            fieldObject.Required = "0";

            this.rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);

            this.formObject = new FormObject();
            formObject.CurrentRow = rowObject;
            formObject.OtherRows.Add(rowObject);

            this.optionObject = new OptionObject();
            optionObject.Forms.Add(formObject);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsFieldPresent_RowObject_IsTrue()
        {
            bool actual = ScriptLinkHelpers.IsFieldPresent(rowObject, "123.45");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsFieldPresent_RowObject_IsFalse()
        {
            bool actual = ScriptLinkHelpers.IsFieldPresent(rowObject, "234.56");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsFieldPresent_FormObject_CurrentRow_IsPresent_AreEqual()
        {
            bool actual = ScriptLinkHelpers.IsFieldPresent(formObject, "123.45");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsFieldPresent_FormObject_CurrentRow_IsFalse()
        {
            bool actual = ScriptLinkHelpers.IsFieldPresent(formObject, "234.56");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsFieldPresent_OptionObject_CurrentRow_IsTrue()
        {
            bool actual = ScriptLinkHelpers.IsFieldPresent(optionObject, "123.45");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("ScriptLinkHelpers")]
        public void IsFieldPresent_OptionObject_CurrentRow_IsFalse()
        {
            bool actual = ScriptLinkHelpers.IsFieldPresent(optionObject, "234.56");
            Assert.IsFalse(actual);
        }
    }
}
