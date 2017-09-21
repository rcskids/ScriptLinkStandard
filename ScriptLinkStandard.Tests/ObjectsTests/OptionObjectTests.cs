using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.EntitiesTests
{
    [TestClass]
    public class OptionObjectTests
    {
        private OptionObject optionObject;
        private OptionObject configuredOptionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.optionObject = new OptionObject();
            this.configuredOptionObject = new OptionObject();

            FieldObject addField = new FieldObject();
            addField.FieldNumber = "123";
            addField.FieldValue = "Value";
            addField.Enabled = "1";
            RowObject addRow = new RowObject();
            addRow.Fields.Add(addField);
            FormObject addForm = new FormObject();
            addForm.CurrentRow = addRow;

            FieldObject addMiField01 = new FieldObject();
            addMiField01.FieldNumber = "234";
            addMiField01.FieldValue = "MI Value";
            FieldObject addMiField02 = new FieldObject();
            addMiField02.FieldNumber = "234";
            addMiField02.FieldValue = "MI Value 2";
            RowObject addMiRow01 = new RowObject();
            addMiRow01.Fields.Add(addMiField01);
            RowObject addMiRow02 = new RowObject();
            addMiRow02.Fields.Add(addMiField01);
            FormObject addMiForm = new FormObject();
            addMiForm.CurrentRow = addMiRow01;
            addMiForm.OtherRows.Add(addMiRow02);
            addMiForm.MultipleIteration = true;

            configuredOptionObject.Forms.Add(addForm);
            configuredOptionObject.Forms.Add(addMiForm);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectHasFormObject()
        {
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObjectFormObjectIsNotEmpty()
        {
            OptionObject testOptionObject = new OptionObject();
            var expected = new List<FormObject>();
            var actual = testOptionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObject_CanGetHtmlString_WithoutHtmlHeaders()
        {
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObject_CanGetHtmlString_WithHtmlHeaders()
        {
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObject_GetCurrentRowId()
        {
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObject_GetFieldValue_AreNotEqual()
        {
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_GetFieldValue_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObject_GetMultipleIterationStatus()
        {
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void NewOptionObject_GetParentRowId()
        {
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldPresent_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldPresent("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldPresent_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldPresent("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldEnabled_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldEnabled_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldEnabled("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_SetDisabledFields_AreEqual()
        {
            var expected = false;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetDisabledFields(requiredFields);
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldLocked_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldLocked_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldLocked("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_SetLockedFields_AreEqual()
        {
            var expected = true;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetLockedFields(requiredFields);
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_SetUnlockedFields_AreEqual()
        {
            var expected = false;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetUnlockedFields(requiredFields);
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldRequired_AreEqual()
        {
            var expected = false;
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_IsFieldRequired_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldRequired("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_SetOptionalFields_Enabled_AreEqual()
        {
            var expected = true;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetOptionalFields(requiredFields);
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_SetOptionalFields_Required_AreEqual()
        {
            var expected = false;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetOptionalFields(requiredFields);
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject")]
        public void ConfiguredOptionObject_SetRequiredFields_AreEqual()
        {
            var expected = true;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetRequiredFields(requiredFields);
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.AreEqual(expected, actual);
        }
    }
}
