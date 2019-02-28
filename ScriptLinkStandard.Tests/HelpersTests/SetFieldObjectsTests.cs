using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class SetFieldObjectsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_NullAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, null, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_BlankAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, "", fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_Null_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject_Disabled_FieldObjectsNotPresent()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject("234")
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_Disabled_FieldObjectsNull()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, null, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, "", fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_Null_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = null;

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                "234"
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject_Disabled_FieldNumbersNull()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject optionObject = new OptionObject();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_NullAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, null, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_BlankAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, "", fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_Null_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2_Disabled_FieldObjectsNotPresent()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject("234")
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_Disabled_FieldObjectsNull()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, null, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, "", fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_Null_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = null;

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                "234"
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2_Disabled_FieldNumbersNull()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2 optionObject = new OptionObject2();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_NullAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, null, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_BlankAction_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, "", fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_Null_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldObjects()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject(fieldNumber)
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldObjectsNotPresent()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = new List<FieldObject>()
            {
                new FieldObject("234")
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldObjectsNull()
        {
            string fieldNumber = "123";
            List<FieldObject> fieldObjects = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldObjects);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, null, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, "", fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_Null_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = null;

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                "234"
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_OptionObject2015_Disabled_FieldNumbersNull()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);
            OptionObject2015 optionObject = new OptionObject2015();
            optionObject.AddFormObject(formObject);

            ScriptLinkHelpers.SetFieldObjects(optionObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(optionObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(optionObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_FormObject_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            ScriptLinkHelpers.SetFieldObjects(formObject, null, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_FormObject_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            ScriptLinkHelpers.SetFieldObjects(formObject, "", fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_FormObject_Null_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = null;

            ScriptLinkHelpers.SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_FormObject_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            ScriptLinkHelpers.SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_FormObject_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                "234"
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            ScriptLinkHelpers.SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_FormObject_Disabled_FieldNumbersNull()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));
            FormObject formObject = new FormObject("1");
            formObject.AddRowObject(rowObject);

            ScriptLinkHelpers.SetFieldObjects(formObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(formObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(formObject.IsFieldRequired(fieldNumber));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_RowObject_NullAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            ScriptLinkHelpers.SetFieldObjects(rowObject, null, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_RowObject_BlankAction_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            ScriptLinkHelpers.SetFieldObjects(rowObject, "", fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_RowObject_Null_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = null;

            ScriptLinkHelpers.SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        public void SetFieldObjects_RowObject_Disabled_FieldNumbers()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                fieldNumber
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            ScriptLinkHelpers.SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SetFieldObjects_RowObject_Disabled_FieldNumbersNotPresent()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = new List<string>()
            {
                "234"
            };
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            ScriptLinkHelpers.SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SetFieldObjects_RowObject_Disabled_FieldNumbersNull()
        {
            string fieldNumber = "123";
            List<string> fieldNumbers = null;
            RowObject rowObject = new RowObject();
            rowObject.AddFieldObject(new FieldObject(fieldNumber));

            ScriptLinkHelpers.SetFieldObjects(rowObject, FieldAction.Disable, fieldNumbers);

            Assert.IsFalse(rowObject.IsFieldEnabled(fieldNumber));
            Assert.IsFalse(rowObject.IsFieldRequired(fieldNumber));
        }
    }
}
