using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.EntitiesTests
{
    [TestClass]
    public class OptionObject2Tests
    {
        private OptionObject2 optionObject;
        private OptionObject2 configuredOptionObject;

        [TestInitialize]
        public void TestInitialize()
        {
            this.optionObject = new OptionObject2();
            this.configuredOptionObject = new OptionObject2();

            FieldObject addField = new FieldObject();
            addField.FieldNumber = "123";
            addField.FieldValue = "Value";
            addField.Enabled = "1";
            RowObject addRow = new RowObject();
            addRow.Fields.Add(addField);
            FormObject addForm = new FormObject();
            addForm.CurrentRow = addRow;

            FieldObject addMiField = new FieldObject();
            addMiField.FieldNumber = "234";
            addMiField.FieldValue = "MI Value";
            addMiField.Enabled = "1";
            RowObject addMiRow = new RowObject();
            addMiRow.Fields.Add(addMiField);
            FormObject addMiForm = new FormObject();
            addMiForm.OtherRows.Add(addMiRow);
            addMiForm.MultipleIteration = true;

            configuredOptionObject.Forms.Add(addForm);
            configuredOptionObject.Forms.Add(addMiForm);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObjectHasFormObject()
        {
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObjectFormObjectIsNotEmpty()
        {
            OptionObject2 testOptionObject = new OptionObject2();
            var expected = new List<FormObject>();
            var actual = testOptionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObject2_CanGetHtmlString_WithoutHtmlHeaders()
        {
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObject2_CanGetHtmlString_WithHtmlHeaders()
        {
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObject2_GetCurrentRowId()
        {
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObject2_GetFieldValue_AreNotEqual()
        {
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_GetFieldValue_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObject2_GetMultipleIterationStatus()
        {
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.AreEqual(false, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void NewOptionObject2_GetParentRowId()
        {
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }
        
        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldPresent_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldPresent("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldPresent_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldPresent("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldEnabled_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldEnabled_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldEnabled("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_SetDisabledFields_AreEqual()
        {
            var expected = false;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetDisabledFields(requiredFields);
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldLocked_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldLocked_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldLocked("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_SetLockedFields_AreEqual()
        {
            var expected = true;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetLockedFields(requiredFields);
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_SetUnlockedFields_AreEqual()
        {
            var expected = false;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetUnlockedFields(requiredFields);
            var actual = configuredOptionObject.IsFieldLocked("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldRequired_AreEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_IsFieldRequired_AreNotEqual()
        {
            var expected = true;
            var actual = configuredOptionObject.IsFieldRequired("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_SetOptionalFields_Enabled_AreEqual()
        {
            var expected = true;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetOptionalFields(requiredFields);
            var actual = configuredOptionObject.IsFieldEnabled("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_SetOptionalFields_Required_AreEqual()
        {
            var expected = false;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetOptionalFields(requiredFields);
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void ConfiguredOptionObject2_SetRequiredFields_AreEqual()
        {
            var expected = true;
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject.SetRequiredFields(requiredFields);
            var actual = configuredOptionObject.IsFieldRequired("123");
            Assert.AreEqual(expected, actual);
        }

    }
}
