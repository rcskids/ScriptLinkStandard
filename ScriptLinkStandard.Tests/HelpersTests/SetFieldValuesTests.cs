﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScriptLinkStandard.Objects;
using ScriptLinkStandard.Helpers;
using System.Collections.Generic;

namespace ScriptLinkStandard.Test.HelpersTests
{
    [TestClass]
    public class SetFieldValuesTests
    {
        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestMethod]
        public void SetFieldValue_FieldObject_AreEqual()
        {
            var expected = new FieldObject();
            var actual = new FieldObject();

            expected.FieldValue = "Test";
            actual = ScriptLinkHelpers.SetFieldValue(actual, "Test");

            Assert.AreEqual(expected.FieldValue, actual.FieldValue);
        }

        [TestMethod]
        public void SetFieldValue_RowObject_AreEqual()
        {
            string expected = "Test";

            var fieldObject = new FieldObject();
            fieldObject.FieldNumber = "123";
            var rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);

            rowObject = ScriptLinkHelpers.SetFieldValue(rowObject, "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(rowObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_FormObject_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject = new FieldObject();
            fieldObject.FieldNumber = "123";
            var rowObject = new RowObject();
            rowObject.Fields.Add(fieldObject);
            var formObject = new FormObject();
            formObject.CurrentRow = rowObject;

            formObject = ScriptLinkHelpers.SetFieldValue(formObject, "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(formObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_FormObject_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "123";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "2||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||2";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||3";
            rowObject03.Fields.Add(fieldObject03);
            var formObject = new FormObject();
            formObject.CurrentRow = rowObject01;
            formObject.OtherRows.Add(rowObject02);
            formObject.OtherRows.Add(rowObject03);
            formObject.MultipleIteration = true;

            formObject = ScriptLinkHelpers.SetFieldValue(formObject, "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(formObject, "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_FormObject_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "123";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "2||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||2";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||3";
            rowObject03.Fields.Add(fieldObject03);
            var formObject = new FormObject();
            formObject.CurrentRow = rowObject01;
            formObject.OtherRows.Add(rowObject02);
            formObject.OtherRows.Add(rowObject03);
            formObject.MultipleIteration = true;

            formObject = ScriptLinkHelpers.SetFieldValue(formObject, "2||2", "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(formObject, "2||2", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_OptionObject_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "122";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var fieldObject04 = new FieldObject();
            fieldObject04.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "1||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||1";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||2";
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject();
            rowObject04.RowId = "2||3";
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject();
            formObject01.FormId = "1";
            formObject01.CurrentRow = rowObject01;
            var formObject02 = new FormObject();
            formObject02.FormId = "2";
            formObject02.CurrentRow = rowObject02;
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = ScriptLinkHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_OptionObject_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "122";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var fieldObject04 = new FieldObject();
            fieldObject04.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "1||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||1";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||2";
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject();
            rowObject04.RowId = "2||3";
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject();
            formObject01.FormId = "1";
            formObject01.CurrentRow = rowObject01;
            var formObject02 = new FormObject();
            formObject02.FormId = "2";
            formObject02.CurrentRow = rowObject02;
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = ScriptLinkHelpers.SetFieldValue(optionObject, "2", "2||1", "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(optionObject, "2", "2||1", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_OptionObject_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "122";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var fieldObject04 = new FieldObject();
            fieldObject04.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "1||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||1";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||2";
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject();
            rowObject04.RowId = "2||3";
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject();
            formObject01.FormId = "1";
            formObject01.CurrentRow = rowObject01;
            var formObject02 = new FormObject();
            formObject02.FormId = "2";
            formObject02.CurrentRow = rowObject02;
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = ScriptLinkHelpers.SetFieldValue(optionObject, "1", "1||1", "122", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(optionObject, "1", "1||1", "122");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_OptionObject2_OtherRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "122";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var fieldObject04 = new FieldObject();
            fieldObject04.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "1||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||1";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||2";
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject();
            rowObject04.RowId = "2||3";
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject();
            formObject01.FormId = "1";
            formObject01.CurrentRow = rowObject01;
            var formObject02 = new FormObject();
            formObject02.FormId = "2";
            formObject02.CurrentRow = rowObject02;
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = ScriptLinkHelpers.SetFieldValue(optionObject, "2", "2||3", "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(optionObject, "2", "2||3", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_OptionObject2_CurrentRow_MI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "122";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var fieldObject04 = new FieldObject();
            fieldObject04.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "1||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||1";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||2";
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject();
            rowObject04.RowId = "2||3";
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject();
            formObject01.FormId = "1";
            formObject01.CurrentRow = rowObject01;
            var formObject02 = new FormObject();
            formObject02.FormId = "2";
            formObject02.CurrentRow = rowObject02;
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = ScriptLinkHelpers.SetFieldValue(optionObject, "2", "2||1", "123", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(optionObject, "2", "2||1", "123");

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SetFieldValue_OptionObject2_CurrentRow_NotMI_AreEqual()
        {
            string expected = "Test";

            var fieldObject01 = new FieldObject();
            fieldObject01.FieldNumber = "122";
            var fieldObject02 = new FieldObject();
            fieldObject02.FieldNumber = "123";
            var fieldObject03 = new FieldObject();
            fieldObject03.FieldNumber = "123";
            var fieldObject04 = new FieldObject();
            fieldObject04.FieldNumber = "123";
            var rowObject01 = new RowObject();
            rowObject01.RowId = "1||1";
            rowObject01.Fields.Add(fieldObject01);
            var rowObject02 = new RowObject();
            rowObject02.RowId = "2||1";
            rowObject02.Fields.Add(fieldObject02);
            var rowObject03 = new RowObject();
            rowObject03.RowId = "2||2";
            rowObject03.Fields.Add(fieldObject03);
            var rowObject04 = new RowObject();
            rowObject04.RowId = "2||3";
            rowObject04.Fields.Add(fieldObject04);
            var formObject01 = new FormObject();
            formObject01.FormId = "1";
            formObject01.CurrentRow = rowObject01;
            var formObject02 = new FormObject();
            formObject02.FormId = "2";
            formObject02.CurrentRow = rowObject02;
            formObject02.OtherRows.Add(rowObject03);
            formObject02.OtherRows.Add(rowObject04);
            formObject02.MultipleIteration = true;
            var optionObject = new OptionObject2();
            optionObject.Forms.Add(formObject01);
            optionObject.Forms.Add(formObject02);

            optionObject = ScriptLinkHelpers.SetFieldValue(optionObject, "1", "1||1", "122", "Test");
            string actual = ScriptLinkHelpers.GetFieldValue(optionObject, "1", "1||1", "122");

            Assert.AreEqual(expected, actual);
        }
    }
}