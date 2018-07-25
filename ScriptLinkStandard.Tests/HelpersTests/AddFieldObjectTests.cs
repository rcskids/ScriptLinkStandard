﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Helpers;
using ScriptLinkStandard.Objects;
using System;

namespace ScriptLinkStandard.Tests.HelpersTests
{
    [TestClass]
    public class AddFieldObjectTests
    {
        [TestMethod]
        [TestCategory("AddFieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFieldObject_ToRowObject_NullRowObject()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "Test",
                Enabled = "1",
                Required = "0",
                Lock = "0"
            };
            ScriptLinkHelpers.AddFieldObject(null, fieldObject);
            Assert.AreNotEqual(null, fieldObject);
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFieldObject_ToRowObject_NullFieldObject()
        {
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, null);
            Assert.AreNotEqual(rowObject, null);
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFieldObject_ToRowObject_DuplicateFieldObject()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "Test",
                Enabled = "1",
                Required = "0",
                Lock = "0"
            };
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, fieldObject);
            ScriptLinkHelpers.AddFieldObject(rowObject, fieldObject);
            Assert.IsFalse(rowObject.IsFieldPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFieldObject_ToRowObject_DuplicateFieldNumber()
        {
            FieldObject fieldObject1 = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "Test",
                Enabled = "1",
                Required = "0",
                Lock = "0"
            };
            FieldObject fieldObject2 = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "Test 2",
                Enabled = "1",
                Required = "0",
                Lock = "0"
            };
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, fieldObject1);
            ScriptLinkHelpers.AddFieldObject(rowObject, fieldObject2);
            Assert.IsFalse(rowObject.IsFieldPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_Succeeds()
        {
            FieldObject fieldObject = new FieldObject()
            {
                FieldNumber = "1",
                FieldValue = "Test",
                Enabled = "1",
                Required = "0",
                Lock = "0"
            };
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, fieldObject);
            Assert.IsTrue(rowObject.IsFieldPresent("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_UsingFieldNumberAndValue()
        {
            string expectedNumber = "1";
            string expectedValue = "Test";
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, expectedNumber, expectedValue);
            Assert.IsTrue(rowObject.IsFieldPresent(expectedNumber));
            Assert.AreEqual(expectedValue, rowObject.GetFieldValue(expectedNumber));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFieldObject_ToRowObject_NullFieldNumber()
        {
            string expectedNumber = null;
            string expectedValue = "Test";
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, expectedNumber, expectedValue);
            Assert.IsTrue(rowObject.IsFieldPresent(expectedNumber));
            Assert.AreEqual(expectedValue, rowObject.GetFieldValue(expectedNumber));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        [ExpectedException(typeof(ArgumentException))]
        public void AddFieldObject_ToRowObject_BlankFieldNumber()
        {
            string expectedNumber = "";
            string expectedValue = "Test";
            RowObject rowObject = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject, expectedNumber, expectedValue);
            Assert.IsTrue(rowObject.IsFieldPresent(expectedNumber));
            Assert.AreEqual(expectedValue, rowObject.GetFieldValue(expectedNumber));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_IsEnabled()
        {
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject1, "1", "Test", "1", "1", "1");
            ScriptLinkHelpers.AddFieldObject(rowObject2, "1", "Test", true, true, true);
            Assert.IsTrue(rowObject1.IsFieldEnabled("1"));
            Assert.IsTrue(rowObject2.IsFieldEnabled("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_IsNotEnabled()
        {
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject1, "1", "Test", "0", "0", "0");
            ScriptLinkHelpers.AddFieldObject(rowObject2, "1", "Test", false, false, false);
            Assert.IsFalse(rowObject1.IsFieldEnabled("1"));
            Assert.IsFalse(rowObject2.IsFieldEnabled("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_IsRequired()
        {
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject1, "1", "Test", "1", "1", "1");
            ScriptLinkHelpers.AddFieldObject(rowObject2, "1", "Test", true, true, true);
            Assert.IsTrue(rowObject1.IsFieldRequired("1"));
            Assert.IsTrue(rowObject2.IsFieldRequired("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_IsNotRequired()
        {
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject1, "1", "Test", "0", "0", "0");
            ScriptLinkHelpers.AddFieldObject(rowObject2, "1", "Test", false, false, false);
            Assert.IsFalse(rowObject1.IsFieldRequired("1"));
            Assert.IsFalse(rowObject2.IsFieldRequired("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_IsLocked()
        {
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject1, "1", "Test", "1", "1", "1");
            ScriptLinkHelpers.AddFieldObject(rowObject2, "1", "Test", true, true, true);
            Assert.IsTrue(rowObject1.IsFieldLocked("1"));
            Assert.IsTrue(rowObject2.IsFieldLocked("1"));
        }

        [TestMethod]
        [TestCategory("AddFieldObject")]
        public void AddFieldObject_ToRowObject_IsNotLocked()
        {
            RowObject rowObject1 = new RowObject();
            RowObject rowObject2 = new RowObject();
            ScriptLinkHelpers.AddFieldObject(rowObject1, "1", "Test", "0", "0", "0");
            ScriptLinkHelpers.AddFieldObject(rowObject2, "1", "Test", false, false, false);
            Assert.IsFalse(rowObject1.IsFieldLocked("1"));
            Assert.IsFalse(rowObject2.IsFieldLocked("1"));
        }
    }
}
