using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class SetEnabledFieldTests
    {

        [TestMethod]
        public void SetEnabledField_OptionObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_OptionObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetEnabledField_OptionObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_OptionObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetEnabledField_OptionObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject optionObject = null;
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_OptionObject2_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetEnabledField_OptionObject2_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_OptionObject2_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetEnabledField_OptionObject2_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2 optionObject = null;
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2015_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_OptionObject2015_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetEnabledField_OptionObject2015_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            optionObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_OptionObject2015_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_OptionObject2015_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetEnabledField_OptionObject2015_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            OptionObject2015 optionObject = null;
            ScriptLinkHelpers.SetEnabledField(optionObject, fieldNumber);
            Assert.IsTrue(optionObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_FormObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_FormObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            formObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetEnabledField_FormObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            formObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_FormObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            ScriptLinkHelpers.SetEnabledField(formObject, fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_FormObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            ScriptLinkHelpers.SetEnabledField(formObject, fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetEnabledField_FormObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            FormObject formObject = null;
            ScriptLinkHelpers.SetEnabledField(formObject, fieldNumber);
            Assert.IsTrue(formObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_RowObject_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_RowObject_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            rowObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void SetEnabledField_RowObject_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            rowObject.SetEnabledField(fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        public void SetEnabledField_RowObject_Helper_FieldNumber()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            ScriptLinkHelpers.SetEnabledField(rowObject, fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetEnabledField_RowObject_Helper_FieldNumber_IsNotPresent()
        {
            string fieldNumber = "123";
            FieldObject fieldObject = new FieldObject(fieldNumber);
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(fieldObject);
            ScriptLinkHelpers.SetEnabledField(rowObject, fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled("234"));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetEnabledField_RowObject_Helper_Null_FieldNumber()
        {
            string fieldNumber = "123";
            RowObject rowObject = null;
            ScriptLinkHelpers.SetEnabledField(rowObject, fieldNumber);
            Assert.IsTrue(rowObject.IsFieldEnabled(fieldNumber));
        }
    }
}
