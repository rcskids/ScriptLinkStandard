using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.EntitiesTests
{
    [TestClass]
    public class OptionObject22Tests
    {
        private OptionObject2 configuredOptionObject2;

        [TestInitialize]
        public void TestInitialize()
        {
            this.configuredOptionObject2 = new OptionObject2();

            FieldObject addField = new FieldObject
            {
                FieldNumber = "123",
                FieldValue = "Value",
                Enabled = "1",
                Lock = "1",
                Required = "1"
            };
            RowObject addRow = new RowObject
            {
                RowId = "1||1"
            };
            addRow.Fields.Add(addField);
            FormObject addForm = new FormObject
            {
                FormId = "1",
                CurrentRow = addRow
            };
            configuredOptionObject2.Forms.Add(addForm);

            FieldObject addMiField01 = new FieldObject
            {
                FieldNumber = "234",
                FieldValue = "MI Value"
            };
            FieldObject addMiField02 = new FieldObject
            {
                FieldNumber = "234",
                FieldValue = "MI Value 2"
            };
            RowObject addMiRow01 = new RowObject
            {
                RowId = "2||1"
            };
            addMiRow01.Fields.Add(addMiField01);
            RowObject addMiRow02 = new RowObject
            {
                RowId = "2||2"
            };
            addMiRow02.Fields.Add(addMiField01);
            FormObject addMiForm = new FormObject
            {
                FormId = "2",
                CurrentRow = addMiRow01,
                MultipleIteration = true
            };
            addMiForm.OtherRows.Add(addMiRow02);
            configuredOptionObject2.Forms.Add(addMiForm);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_HasFormObject()
        {
            OptionObject2 optionObject = new OptionObject2();
            Assert.IsNotNull(optionObject.Forms);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_Forms_IsNotEmpty()
        {
            OptionObject2 optionObject = new OptionObject2();
            var expected = new List<FormObject>();
            var actual = optionObject.Forms;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_CanGetHtmlString_WithoutHtmlHeaders()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_CanGetHtmlString_WithHtmlHeaders()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.ToHtmlString(false);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_AddFormObject_FormObject()
        {
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject2);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_AddFormObject_FormObject_Exception()
        {
            FormObject formObject1 = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            FormObject formObject2 = new FormObject
            {
                FormId = "2",
                MultipleIteration = true
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject(formObject1);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_AddFormObject_Properties()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("2", true);
            Assert.AreEqual(2, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_AddFormObject_Properties_Exception()
        {
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
            optionObject.AddFormObject("1", false);
            Assert.AreEqual(1, optionObject.Forms.Count);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetCurrentRowId_Error()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetCurrentRowId_AreEqual()
        {
            RowObject rowObject = new RowObject
            {
                RowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetCurrentRowId("1");
            Assert.AreEqual("1||1", actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValue_AreEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2.GetFieldValue("123");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValue_AreNotEqual()
        {
            OptionObject2 optionObject = new OptionObject2();
            var expected = "Value";
            var actual = optionObject.GetFieldValue("123");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValue_MI_AreEqual()
        {
            var expected = "MI Value";
            var actual = configuredOptionObject2.GetFieldValue("234");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValue_MI_AreNotEqual()
        {
            var expected = "Value";
            var actual = configuredOptionObject2.GetFieldValue("456");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValues_AreEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2.GetFieldValues("123");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValues_MI_AreEqual()
        {
            var expected = "MI Value";
            var values = configuredOptionObject2.GetFieldValues("234");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetFieldValues_AreNotEqual()
        {
            var expected = "Value";
            var values = configuredOptionObject2.GetFieldValues("456");
            var actual = values.Count > 0 ? values[0] : null;
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetMultipleIterationStatus_IsFalse()
        {
            OptionObject2 optionObject = new OptionObject2();
            FormObject formObject = new FormObject
            {
                FormId = "1",
                MultipleIteration = false
            };
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetMultipleIterationStatus_IsNotFound()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.GetMultipleIterationStatus("1");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetMultipleIterationStatus_IsTrue()
        {
            var actual = configuredOptionObject2.GetMultipleIterationStatus("2");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OptionObject2_GetParentRowId_Error()
        {
            OptionObject2 optionObject = new OptionObject2();
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(null, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_GetParentRowId_AreEqual()
        {
            RowObject rowObject = new RowObject
            {
                ParentRowId = "1||1"
            };
            FormObject formObject = new FormObject
            {
                FormId = "1",
                CurrentRow = rowObject
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject);
            var actual = optionObject.GetParentRowId("1");
            Assert.AreEqual(rowObject.ParentRowId, actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldPresent_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldPresent("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldPresent_IsFalse()
        {
            var actual = configuredOptionObject2.IsFieldPresent("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldEnabled_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldEnabled("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldEnabled_IsFalse()
        {
            var actual = configuredOptionObject2.IsFieldEnabled("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetDisabledFields_IsTrue()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2.SetDisabledFields(requiredFields);
            var actual = configuredOptionObject2.IsFieldEnabled("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldLocked_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldLocked("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldLocked_IsFalse()
        {
            var actual = configuredOptionObject2.IsFieldLocked("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetUnlockedFields_IsTrue()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2.SetUnlockedFields(requiredFields);
            Assert.IsTrue(!configuredOptionObject2.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetLockedFields_IsTrue()
        {
            List<string> lockedFields = new List<string> { "123" };
            configuredOptionObject2.SetLockedFields(lockedFields);
            Assert.IsTrue(configuredOptionObject2.IsFieldLocked("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldRequired_IsTrue()
        {
            var actual = configuredOptionObject2.IsFieldRequired("123");
            Assert.IsTrue(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_IsFieldRequired_AreNotEqual()
        {
            var actual = configuredOptionObject2.IsFieldRequired("456");
            Assert.IsFalse(actual);
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetOptionalFields_IsTrue()
        {
            List<string> optionalFields = new List<string> { "123" };
            configuredOptionObject2.SetOptionalFields(optionalFields);
            Assert.IsTrue(configuredOptionObject2.IsFieldEnabled("123"));
            Assert.IsFalse(configuredOptionObject2.IsFieldRequired("123"));
        }

        [TestMethod]
        [TestCategory("OptionObject2")]
        public void OptionObject2_SetRequiredFields_AreEqual()
        {
            List<string> requiredFields = new List<string> { "123" };
            configuredOptionObject2.SetRequiredFields(requiredFields);
            Assert.IsTrue(configuredOptionObject2.IsFieldEnabled("123"));
            Assert.IsTrue(configuredOptionObject2.IsFieldRequired("123"));
        }

    }
}
