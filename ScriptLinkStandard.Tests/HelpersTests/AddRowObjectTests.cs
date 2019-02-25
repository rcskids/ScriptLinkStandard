using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class AddRowObjectTests
    {
        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToFormObject_NullFormObject()
        {
            RowObject rowObject = new RowObject();
            FormObject formObject = null;
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject);
            Assert.AreEqual(1, formObject);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToFormObject_NullRowObject()
        {
            RowObject rowObject = null;
            FormObject formObject = new FormObject();
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject);
            Assert.AreEqual(1, formObject);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_DefinedRowId_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject = new RowObject()
            {
                RowId = expected
            };
            FormObject formObject = new FormObject()
            {
                FormId = formId
            };
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_UndefinedRowId_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId
            };
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_Multiple_MI()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId,
                MultipleIteration = true
            };
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject2);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddRowObject_ToFormObject_Multiple_NonMI()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId
            };
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject2);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddRowObject_ToFormObject_Duplicate_MI()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject()
            {
                RowId = expected
            };
            RowObject rowObject2 = new RowObject()
            {
                RowId = expected
            };
            FormObject formObject = new FormObject()
            {
                FormId = formId,
                MultipleIteration = true
            };
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject2);
            Assert.AreEqual(expected, formObject.CurrentRow.RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToFormObject_MI_Success()
        {
            string formId = "1";
            string expected1 = "1||1";
            string expected2 = "1||2";
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId,
                MultipleIteration = true
            };
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject1);
            formObject = (FormObject)ScriptLinkHelpers.AddRowObject(formObject, rowObject2);
            Assert.IsTrue(formObject.IsRowPresent(expected1));
            Assert.AreEqual(expected1, formObject.CurrentRow.RowId);
            Assert.IsTrue(formObject.IsRowPresent(expected2));
            Assert.AreEqual(expected2, formObject.OtherRows[0].RowId);
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject_NullFormId()
        {
            string formId = null;
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject2_NullFormId()
        {
            string formId = null;
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddRowObject_ToOptionObject2015_NullFormId()
        {
            string formId = null;
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2015)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRowObject_ToOptionObject_FormIdNotPresent()
        {
            string formId = "2";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRowObject_ToOptionObject2_FormIdNotPresent()
        {
            string formId = "2";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddRowObject_ToOptionObject2015_FormIdNotPresent()
        {
            string formId = "2";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = "1",
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2015)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId,
                MultipleIteration = false
            };
            OptionObject optionObject = new OptionObject();
            optionObject = (OptionObject)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId,
                MultipleIteration = false
            };
            OptionObject2 optionObject = new OptionObject2();
            optionObject = (OptionObject2)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }

        [TestMethod]
        [TestCategory("AddRowObject")]
        public void AddRowObject_ToOptionObject2015_Success()
        {
            string formId = "1";
            string expected = "1||1";
            RowObject rowObject1 = new RowObject();
            FormObject formObject = new FormObject()
            {
                FormId = formId,
                MultipleIteration = false
            };
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject = (OptionObject2015)ScriptLinkHelpers.AddFormObject(optionObject, formObject);
            optionObject = (OptionObject2015)ScriptLinkHelpers.AddRowObject(optionObject, formId, rowObject1);
            Assert.IsTrue(optionObject.IsRowPresent(expected));
        }
    }
}
