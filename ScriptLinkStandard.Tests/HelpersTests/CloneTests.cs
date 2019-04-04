using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class CloneTests
    {
        [TestMethod]
        public void Clone_OptionObject_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject optionObject = new OptionObject("USER00", "userId", "000111", "1", "123456", 1, "UAT");
            optionObject.AddFormObject(formObject);

            OptionObject cloneOptionObject = (OptionObject)ScriptLinkHelpers.Clone(optionObject);

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_OptionObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject optionObject = new OptionObject("USER00", "userId", "000111", "1", "123456", 1, "UAT");
            optionObject.AddFormObject(formObject);

            OptionObject cloneOptionObject = (OptionObject)ScriptLinkHelpers.Clone(optionObject);
            optionObject.SetFieldValue("123", "Modified");

            Assert.AreNotEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_OptionObject2_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2 optionObject = new OptionObject2("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER");
            optionObject.AddFormObject(formObject);

            OptionObject2 cloneOptionObject = (OptionObject2)ScriptLinkHelpers.Clone(optionObject);

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_OptionObject2_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2 optionObject = new OptionObject2("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER");
            optionObject.AddFormObject(formObject);

            OptionObject2 cloneOptionObject = (OptionObject2)ScriptLinkHelpers.Clone(optionObject);
            optionObject.SetFieldValue("123", "Modified");

            Assert.AreNotEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_OptionObject2015_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2015 optionObject = new OptionObject2015("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 cloneOptionObject = (OptionObject2015)ScriptLinkHelpers.Clone(optionObject);

            Assert.AreEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_OptionObject2015_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);
            OptionObject2015 optionObject = new OptionObject2015("USER00", "userId", "000111", "1", "123456", 1, "UAT", "AVPM", "AVPM", "SERVER", "TOKEN");
            optionObject.AddFormObject(formObject);

            OptionObject2015 cloneOptionObject = (OptionObject2015)ScriptLinkHelpers.Clone(optionObject);
            optionObject.SetFieldValue("123", "Modified");

            Assert.AreNotEqual(optionObject, cloneOptionObject);
            Assert.IsTrue(optionObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneOptionObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_FormObject_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);

            FormObject cloneFormObject = (FormObject)ScriptLinkHelpers.Clone(formObject);

            Assert.AreEqual(formObject, cloneFormObject);
            Assert.IsTrue(formObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneFormObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_FormObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);
            FormObject formObject = new FormObject("1", rowObject);

            FormObject cloneFormObject = (FormObject)ScriptLinkHelpers.Clone(formObject);
            formObject.DeleteRowObject(rowObject);

            Assert.AreNotEqual(formObject, cloneFormObject);
            Assert.IsTrue(formObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneFormObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_RowObject_AreEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);

            RowObject cloneRowObject = (RowObject)ScriptLinkHelpers.Clone(rowObject);

            Assert.AreEqual(rowObject, cloneRowObject);
            Assert.IsTrue(rowObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneRowObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_RowObject_AreNotEqual()
        {
            List<FieldObject> fieldObjects = new List<FieldObject>
            {
                new FieldObject("123", "Test")
            };
            RowObject rowObject = new RowObject("1||1", fieldObjects);

            RowObject cloneRowObject = (RowObject)ScriptLinkHelpers.Clone(rowObject);
            rowObject.RemoveFieldObject("123");

            Assert.AreNotEqual(rowObject, cloneRowObject);
            Assert.IsFalse(rowObject.IsFieldPresent("123"));
            Assert.IsTrue(cloneRowObject.IsFieldPresent("123"));
        }

        [TestMethod]
        public void Clone_FieldObject_AreEqual()
        {
            FieldObject fieldObject = new FieldObject("123", "Test");

            FieldObject cloneFieldObject = (FieldObject)ScriptLinkHelpers.Clone(fieldObject);

            Assert.AreEqual(fieldObject, cloneFieldObject);
        }

        [TestMethod]
        public void Clone_FieldObject_AreNotEqual()
        {
            FieldObject fieldObject = new FieldObject("123", "Test");

            FieldObject cloneFieldObject = (FieldObject)ScriptLinkHelpers.Clone(fieldObject);
            fieldObject.SetFieldValue("Modified");

            Assert.AreNotEqual(fieldObject, cloneFieldObject);
        }
    }
}
